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

        public const string FIELD_POINTS_TOTAL = "{POINTS_TOTAL}";
        public const string FIELD_POINTS_A = "{POINTS_A}";
        public const string FIELD_POINTS_B = "{POINTS_B}";
        public const string FIELD_NAME_A = "{NAME_A}";
        public const string FIELD_NAME_B = "{NAME_B}";
        public const string FIELD_RETURN_A = "{RETURN_A}";
        public const string FIELD_RETURN_B = "{RETURN_B}";
        public const string FIELD_TOP_BETTERS_A = "{TOP_BETTERS_A}";
        public const string FIELD_TOP_BETTERS_B = "{TOP_BETTERS_B}";

        private string TEMPLATE_SUMMARY_ACTIVE = $"Bet active, {FIELD_POINTS_TOTAL} wagered\n\n{FIELD_POINTS_A} on {FIELD_NAME_A}, {FIELD_RETURN_A}% return\nBiggest {FIELD_NAME_A} believers{FIELD_TOP_BETTERS_A}\n\n{FIELD_POINTS_B} on {FIELD_NAME_B}, {FIELD_RETURN_B}% return\nBiggest {FIELD_NAME_B} believers{FIELD_TOP_BETTERS_B}";
        private string TEMPLATE_SUMMARY_LOCKED = $"Bet locked, {FIELD_POINTS_TOTAL} wagered\n\n{FIELD_POINTS_A} on {FIELD_NAME_A}, {FIELD_RETURN_A}% return\nBiggest {FIELD_NAME_A} believers{FIELD_TOP_BETTERS_A}\n\n{FIELD_POINTS_B} on {FIELD_NAME_B}, {FIELD_RETURN_B}% return\nBiggest {FIELD_NAME_B} believers{FIELD_TOP_BETTERS_B}";
        private string TEMPLATE_SUMMARY_CANCELED = $"Bet cancelled, points refunded";
        private string TEMPLATE_SUMMARY_RESOLVED = $"Bet resolved, {FIELD_POINTS_TOTAL} wagered\n\n{FIELD_POINTS_A} on {FIELD_NAME_A}, {FIELD_RETURN_A}% return\nBiggest {FIELD_NAME_A} believers{FIELD_TOP_BETTERS_A}\n\n{FIELD_POINTS_B} on {FIELD_NAME_B}\nBiggest {FIELD_NAME_A} doubters{FIELD_TOP_BETTERS_B}";

        private string TEMPLATE_SINGLE_ACTIVE = $"Total Wager\n{FIELD_POINTS_A}\n\nPayout\n{FIELD_RETURN_A}\n\nBiggest believers{FIELD_TOP_BETTERS_A}";
        private string TEMPLATE_SINGLE_LOCKED = $"Total Wager\n{FIELD_POINTS_A}\n\nPayout\n{FIELD_RETURN_A}\n\nBiggest believers{FIELD_TOP_BETTERS_A}";
        private string TEMPLATE_SINGLE_CANCELED = $"Bet cancelled, points refunded";
        private string TEMPLATE_SINGLE_RESOLVED = $"Total Wager\n{FIELD_POINTS_A}\n\nPayout\n{FIELD_RETURN_A}\n\nBiggest believers{FIELD_TOP_BETTERS_A}";

        public string Summary
        {
            get
            {
                try
                {
                    string value = "";

                    if (status == "ACTIVE")
                        value = FillTemplateFields(TEMPLATE_SUMMARY_ACTIVE, outcomes[0], outcomes[1]);
                    else if (status == "LOCKED")
                        value = FillTemplateFields(TEMPLATE_SUMMARY_LOCKED, outcomes[0], outcomes[1]);
                    else if (status == "CANCELED")
                        value = FillTemplateFields(TEMPLATE_SUMMARY_CANCELED, outcomes[0], outcomes[1]);
                    else if (status == "RESOLVED")
                    {
                        if (winning_outcome_id == outcomes[0].id)
                            value = FillTemplateFields(TEMPLATE_SUMMARY_RESOLVED, outcomes[0], outcomes[1]);
                        else
                            value = FillTemplateFields(TEMPLATE_SUMMARY_RESOLVED, outcomes[1], outcomes[0]);
                    }

                    return value;
                }
                catch (Exception)
                {
                    return "Failed to build prediction summary.";
                }
            }
        }

        public string Left
        {
            get
            {
                try
                {
                    string value = "";

                    if (status == "ACTIVE")
                        value = FillTemplateFields(TEMPLATE_SINGLE_ACTIVE, outcomes[0], outcomes[1]);
                    else if (status == "LOCKED")
                        value = FillTemplateFields(TEMPLATE_SINGLE_LOCKED, outcomes[0], outcomes[1]);
                    else if (status == "CANCELED")
                        value = FillTemplateFields(TEMPLATE_SINGLE_CANCELED, outcomes[0], outcomes[1]);
                    else if (status == "RESOLVED")
                        value = FillTemplateFields(TEMPLATE_SINGLE_RESOLVED, outcomes[0], outcomes[1]);

                    return value;
                }
                catch (Exception)
                {
                    return "Failed to build prediction summary.";
                }
            }
        }

        public string Right
        {
            get
            {
                try
                {
                    string value = "";

                    if (status == "ACTIVE")
                        value = FillTemplateFields(TEMPLATE_SINGLE_ACTIVE, outcomes[1], outcomes[0]);
                    else if (status == "LOCKED")
                        value = FillTemplateFields(TEMPLATE_SINGLE_LOCKED, outcomes[1], outcomes[0]);
                    else if (status == "CANCELLED")
                        value = FillTemplateFields(TEMPLATE_SINGLE_CANCELED, outcomes[1], outcomes[0]);
                    else if (status == "RESOLVED")
                        value = FillTemplateFields(TEMPLATE_SINGLE_RESOLVED, outcomes[1], outcomes[0]);

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
            if (value.Contains(FIELD_POINTS_TOTAL))
                value = value.Replace(FIELD_POINTS_TOTAL, string.Format("{0:n0}", outcomeA.channel_points + outcomeB.channel_points));

            if (value.Contains(FIELD_POINTS_A))
                value = value.Replace(FIELD_POINTS_A, string.Format("{0:n0}", outcomeA.channel_points));

            if (value.Contains(FIELD_POINTS_B))
                value = value.Replace(FIELD_POINTS_B, string.Format("{0:n0}", outcomeB.channel_points));

            if (value.Contains(FIELD_NAME_A))
                value = value.Replace(FIELD_NAME_A, string.Format("{0:n0}", outcomeA.title));

            if (value.Contains(FIELD_NAME_B))
                value = value.Replace(FIELD_NAME_B, string.Format("{0:n0}", outcomeB.title));

            if (value.Contains(FIELD_RETURN_A) || value.Contains(FIELD_RETURN_B))
            {
                if (outcomeA.channel_points > 0 && outcomeB.channel_points > 0)
                {
                    double ratioWinnerA = (double)outcomeA.channel_points / outcomeA.channel_points;
                    double ratioWinnerB = (double)outcomeB.channel_points / outcomeB.channel_points;

                    value = value.Replace(FIELD_RETURN_A, string.Format("+{0:n0}", ratioWinnerA * 100));
                    value = value.Replace(FIELD_RETURN_B, string.Format("+{0:n0}", ratioWinnerB * 100));
                }
                else
                {
                    value = value.Replace(FIELD_RETURN_A, "0");
                    value = value.Replace(FIELD_RETURN_B, "0");
                }
            }

            if (value.Contains(FIELD_TOP_BETTERS_A))
            {
                if (outcomeA.top_predictors != null)
                {
                    string topBetters = "";
                    foreach (TopPredictor supporter in outcomeA.top_predictors.OrderByDescending(q => q.channel_points_used).Take(3))
                        topBetters += "\n" + supporter.user_name + ": " + string.Format("{0:n0}", supporter.channel_points_used);
                    value = value.Replace(FIELD_TOP_BETTERS_A, topBetters);
                }
                else
                {
                    value = value.Replace(FIELD_TOP_BETTERS_A, "\n(none)");
                }
            }

            if (value.Contains(FIELD_TOP_BETTERS_B))
            {
                if (outcomeB.top_predictors != null)
                {
                    string topBetters = "";
                    foreach (TopPredictor supporter in outcomeB.top_predictors.OrderByDescending(q => q.channel_points_used).Take(3))
                        topBetters += "\n" + supporter.user_name + ": " + string.Format("{0:n0}", supporter.channel_points_used);
                    value = value.Replace(FIELD_TOP_BETTERS_B, topBetters);
                }
                else
                {
                    value = value.Replace(FIELD_TOP_BETTERS_B, "\n(none)");
                }
            }

            return value;
        }
    }
}
