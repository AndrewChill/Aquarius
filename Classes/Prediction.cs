using System;
using System.Collections.Generic;
using System.Linq;

namespace Aquarius
{
    public class Prediction
    {
        public string id { get; set; }
        public string broadcaster_id { get; set; }
        public string broadcaster_name { get; set; }
        public string broadcaster_login { get; set; }
        public string title { get; set; }
        public string winning_outcome_id { get; set; }
        public List<Outcome> outcomes { get; set; }
        public int prediction_window { get; set; }
        public string status { get; set; }
        public string created_at { get; set; }
        public string ended_at { get; set; }
        public string locked_at { get; set; }

        public string SummaryDouble
        {
            get
            {
                try
                {
                    string value = "";

                    if (status == "ACTIVE")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateDoubleActive, outcomes[0], outcomes[1]);
                    else if (status == "LOCKED")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateDoubleLocked, outcomes[0], outcomes[1]);
                    else if (status == "CANCELED")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateDoubleCanceled, outcomes[0], outcomes[1]);
                    else if (status == "RESOLVED")
                    {
                        if (winning_outcome_id == outcomes[0].id)
                            value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateDoubleResolved, outcomes[0], outcomes[1]);
                        else
                            value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateDoubleResolved, outcomes[1], outcomes[0]);
                    }

                    return value;
                }
                catch (Exception)
                {
                    return "Failed to build prediction summary.";
                }
            }
        }

        public string SummaryLeft
        {
            get
            {
                try
                {
                    string value = "";

                    if (status == "ACTIVE")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateSingleActive, outcomes[0], outcomes[1]);
                    else if (status == "LOCKED")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateSingleLocked, outcomes[0], outcomes[1]);
                    else if (status == "CANCELED")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateSingleCanceled, outcomes[0], outcomes[1]);
                    else if (status == "RESOLVED")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateSingleResolved, outcomes[0], outcomes[1]);

                    return value;
                }
                catch (Exception)
                {
                    return "Failed to build prediction summary.";
                }
            }
        }

        public string SummaryRight
        {
            get
            {
                try
                {
                    string value = "";

                    if (status == "ACTIVE")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateSingleActive, outcomes[1], outcomes[0]);
                    else if (status == "LOCKED")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateSingleLocked, outcomes[1], outcomes[0]);
                    else if (status == "CANCELLED")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateSingleCanceled, outcomes[1], outcomes[0]);
                    else if (status == "RESOLVED")
                        value = FillTemplateFields(SettingsManager.Instance.Settings.TemplateSingleResolved, outcomes[1], outcomes[0]);

                    return value;
                }
                catch (Exception)
                {
                    return "Failed to build prediction summary.";
                }
            }
        }

        private string FillTemplateFields(string value, Outcome outcomeA, Outcome outcomeB)
        {
            if (value.Contains(TemplateFields.FIELD_POINTS_TOTAL))
                value = value.Replace(TemplateFields.FIELD_POINTS_TOTAL, string.Format("{0:n0}", outcomeA.channel_points + outcomeB.channel_points));

            if (value.Contains(TemplateFields.FIELD_POINTS_A))
                value = value.Replace(TemplateFields.FIELD_POINTS_A, string.Format("{0:n0}", outcomeA.channel_points));

            if (value.Contains(TemplateFields.FIELD_POINTS_B))
                value = value.Replace(TemplateFields.FIELD_POINTS_B, string.Format("{0:n0}", outcomeB.channel_points));

            if (value.Contains(TemplateFields.FIELD_NAME_A))
                value = value.Replace(TemplateFields.FIELD_NAME_A, string.Format("{0:n0}", outcomeA.title));

            if (value.Contains(TemplateFields.FIELD_NAME_B))
                value = value.Replace(TemplateFields.FIELD_NAME_B, string.Format("{0:n0}", outcomeB.title));

            if (value.Contains(TemplateFields.FIELD_RETURN_A) || value.Contains(TemplateFields.FIELD_RETURN_B))
            {
                if (outcomeA.channel_points > 0 && outcomeB.channel_points > 0)
                {
                    double ratioWinnerA = (double)outcomeB.channel_points / outcomeA.channel_points;
                    double ratioWinnerB = (double)outcomeA.channel_points / outcomeB.channel_points;

                    value = value.Replace(TemplateFields.FIELD_RETURN_A, string.Format("+{0:n0}", ratioWinnerA * 100));
                    value = value.Replace(TemplateFields.FIELD_RETURN_B, string.Format("+{0:n0}", ratioWinnerB * 100));
                }
                else
                {
                    value = value.Replace(TemplateFields.FIELD_RETURN_A, "(none)");
                    value = value.Replace(TemplateFields.FIELD_RETURN_B, "(none)");
                }
            }

            if (value.Contains(TemplateFields.FIELD_TOP_BETTERS_A))
            {
                if (outcomeA.top_predictors != null && outcomeA.top_predictors.Count > 0)
                {
                    string topBetters = "";
                    foreach (TopPredictor supporter in outcomeA.top_predictors.OrderByDescending(q => q.channel_points_used).Take(SettingsManager.Instance.Settings.BettorsToDisplay))
                        topBetters += supporter.user_name + ": " + string.Format("{0:n0}", supporter.channel_points_used) + "<br>";
                    topBetters = topBetters.Substring(0, topBetters.Length - 4);
                    value = value.Replace(TemplateFields.FIELD_TOP_BETTERS_A, topBetters);
                }
                else
                {
                    value = value.Replace(TemplateFields.FIELD_TOP_BETTERS_A, "(none)");
                }
            }

            if (value.Contains(TemplateFields.FIELD_TOP_BETTERS_B))
            {
                if (outcomeB.top_predictors != null && outcomeB.top_predictors.Count > 0)
                {
                    string topBetters = "";
                    foreach (TopPredictor supporter in outcomeB.top_predictors.OrderByDescending(q => q.channel_points_used).Take(SettingsManager.Instance.Settings.BettorsToDisplay))
                        topBetters += supporter.user_name + ": " + string.Format("{0:n0}", supporter.channel_points_used) + "<br>";
                    topBetters = topBetters.Substring(0, topBetters.Length - 4);
                    value = value.Replace(TemplateFields.FIELD_TOP_BETTERS_B, topBetters);
                }
                else
                {
                    value = value.Replace(TemplateFields.FIELD_TOP_BETTERS_B, "(none)");
                }
            }

            return value;
        }
    }
}
