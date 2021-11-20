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

        public string Summary
        {
            get
            {
                try
                {
                    string value = "";
                    if (string.IsNullOrWhiteSpace(winning_outcome_id))
                    {
                        Outcome outcomePlayer1 = outcomes[0];
                        Outcome outcomePlayer2 = outcomes[1];

                        string namePlayer1 = outcomePlayer1.title.Substring(11);
                        string namePlayer2 = outcomePlayer2.title.Substring(11);
                        int totalPoints = outcomePlayer1.channel_points + outcomePlayer2.channel_points;

                        value += string.Format("{0:n0}", totalPoints) + " wagered\n\n";

                        double ratioPlayer1Wins = (double)outcomePlayer2.channel_points / outcomePlayer1.channel_points;
                        double ratioPlayer2Wins = (double)outcomePlayer1.channel_points / outcomePlayer2.channel_points;

                        value += string.Format("{0:n0}", outcomePlayer1.channel_points) + $" on {namePlayer1}, " + string.Format("+{0:n0}", ratioPlayer1Wins * 100) + "% return\n";

                        Dictionary<string, int> supportersPlayer1 = new Dictionary<string, int>();
                        foreach (TopPredictor supporter in outcomePlayer1.top_predictors.OrderByDescending(q => q.channel_points_used).Take(3))
                            supportersPlayer1.Add(supporter.user_name, supporter.channel_points_used);
                        value += $"Biggest {namePlayer1} believers";
                        foreach (KeyValuePair<string, int> supporter in supportersPlayer1)
                            value += "\n" + supporter.Key + ": " + string.Format("{0:n0}", supporter.Value);

                        value += string.Format("\n\n{0:n0}", outcomePlayer2.channel_points) + $" on {namePlayer2}, " + string.Format("+{0:n0}", ratioPlayer2Wins * 100) + "% return\n";

                        Dictionary<string, int> supportersPlayer2 = new Dictionary<string, int>();
                        foreach (TopPredictor supporter in outcomePlayer2.top_predictors.OrderByDescending(q => q.channel_points_used).Take(3))
                            supportersPlayer2.Add(supporter.user_name, supporter.channel_points_used);
                        value += $"Biggest {namePlayer2} believers";
                        foreach (KeyValuePair<string, int> supporter in supportersPlayer2)
                            value += "\n" + supporter.Key + ": " + string.Format("{0:n0}", supporter.Value);
                    }
                    else
                    {
                        Outcome winningOutcome = outcomes.Single(q => q.id == winning_outcome_id);
                        Outcome losingOutcome = outcomes.Single(q => q.id != winning_outcome_id);

                        if (winningOutcome == null || losingOutcome == null || winningOutcome.channel_points == 0 || losingOutcome.channel_points == 0)
                            return "";

                        string nameWinner = winningOutcome.title.Substring(11);
                        string nameLoser = losingOutcome.title.Substring(11);

                        double ratio = (double)losingOutcome.channel_points / winningOutcome.channel_points;
                        int totalPoints = winningOutcome.channel_points + losingOutcome.channel_points;

                        Dictionary<string, int> winners = new Dictionary<string, int>();
                        foreach (TopPredictor winner in winningOutcome.top_predictors.Take(3))
                            winners.Add(winner.user_name, (int)(winner.channel_points_used * ratio));

                        Dictionary<string, int> losers = new Dictionary<string, int>();
                        foreach (TopPredictor loser in losingOutcome.top_predictors.Take(3))
                            losers.Add(loser.user_name, loser.channel_points_used);

                        value += string.Format("{0:n0}", totalPoints) + " wagered\n";
                        value += string.Format("+{0:n0}", ratio * 100) + $"% return on {nameWinner}\n";
                        value += $"\nBiggest {nameWinner} believers";
                        foreach (KeyValuePair<string, int> winner in winners)
                            value += "\n" + winner.Key + ": +" + string.Format("{0:n0}", winner.Value);

                        value += $"\n\nBiggest {nameWinner} doubters";
                        foreach (KeyValuePair<string, int> loser in losers)
                            value += "\n" + loser.Key + ": -" + string.Format("{0:n0}", loser.Value);
                    }
                    return value;
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }

        public string Left
        {
            get
            {
                return GetSingleOutcomeSummary(outcomes[0], outcomes[1]);
            }
        }

        public string Right
        {
            get
            {
                return GetSingleOutcomeSummary(outcomes[1], outcomes[0]);
            }
        }

        private string GetSingleOutcomeSummary(Outcome main, Outcome compare)
        {
            try
            {
                string value = "";

                if (string.IsNullOrWhiteSpace(winning_outcome_id))
                {
                    int totalPoints = main.channel_points + compare.channel_points;

                    value += string.Format("{0:n0}", main.channel_points) + " wagered\n\n";

                    double ratioLeftWins = (double)compare.channel_points / main.channel_points;
                    double ratioRightWins = (double)main.channel_points / compare.channel_points;

                    value += string.Format("+{0:n0}", ratioLeftWins * 100) + "% return\n\n";

                    value += $"Biggest believers";
                    foreach (TopPredictor supporter in main.top_predictors.OrderByDescending(q => q.channel_points_used).Take(3))
                        value += "\n" + supporter.user_name + ": " + string.Format("{0:n0}", supporter.channel_points_used);
                }
                else
                {
                    if (winning_outcome_id == main.id)
                    {
                        value += string.Format("{0:n0}", main.channel_points) + " won\n\n";

                        double ratioLeftWins = (double)compare.channel_points / main.channel_points;
                        double ratioRightWins = (double)main.channel_points / compare.channel_points;

                        value += string.Format("+{0:n0}", ratioLeftWins * 100) + "% return\n\n";

                        value += $"Biggest believers";
                        foreach (TopPredictor supporter in main.top_predictors.OrderByDescending(q => q.channel_points_used).Take(3))
                            value += "\n" + supporter.user_name + ": " + string.Format("{0:n0}", supporter.channel_points_used);
                    }
                    else
                    {
                        value += string.Format("{0:n0}", main.channel_points) + " lost\n\n";

                        value += $"Biggest believers";
                        foreach (TopPredictor supporter in main.top_predictors.OrderByDescending(q => q.channel_points_used).Take(3))
                            value += "\n" + supporter.user_name + ": " + string.Format("{0:n0}", supporter.channel_points_used);
                    }
                }

                return value;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
