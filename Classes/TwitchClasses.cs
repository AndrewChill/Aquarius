using System.Collections.Generic;
using System.Linq;
using System;

namespace Aquarius
{
    public class TopPredictor
    {
        public string user_id { get; set; }
        public string user_login { get; set; }
        public string user_name { get; set; }
        public int channel_points_used { get; set; }
        public int channel_points_won { get; set; }
    }

    public class Outcome
    {
        public string id { get; set; }
        public string title { get; set; }
        public int users { get; set; }
        public int channel_points { get; set; }
        public List<TopPredictor> top_predictors { get; set; }
        public string color { get; set; }
    }

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
                    string summary = "";
                    if (string.IsNullOrWhiteSpace(winning_outcome_id))
                    {
                        Outcome outcomePlayer1 = outcomes[0];
                        Outcome outcomePlayer2 = outcomes[1];

                        string namePlayer1 = outcomePlayer1.title.Substring(11);
                        string namePlayer2 = outcomePlayer2.title.Substring(11);
                        int totalPoints = outcomePlayer1.channel_points + outcomePlayer2.channel_points;

                        summary += string.Format("{0:n0}", totalPoints) + " wagered\n\n";

                        double ratioPlayer1Wins = (double)outcomePlayer2.channel_points / outcomePlayer1.channel_points;
                        double ratioPlayer2Wins = (double)outcomePlayer1.channel_points / outcomePlayer2.channel_points;

                        summary += string.Format("{0:n0}", outcomePlayer1.channel_points) + $" on {namePlayer1}, " + string.Format("+{0:n0}", ratioPlayer1Wins * 100) + "% return\n";

                        Dictionary<string, int> supportersPlayer1 = new Dictionary<string, int>();
                        foreach (TopPredictor supporter in outcomePlayer1.top_predictors.OrderByDescending(q => q.channel_points_used).Take(3))
                            supportersPlayer1.Add(supporter.user_name, supporter.channel_points_used);
                        summary += $"Biggest {namePlayer1} believers";
                        foreach (KeyValuePair<string, int> supporter in supportersPlayer1)
                            summary += "\n" + supporter.Key + ": " + string.Format("{0:n0}", supporter.Value);

                        summary += string.Format("\n\n{0:n0}", outcomePlayer2.channel_points) + $" on {namePlayer2}, " + string.Format("+{0:n0}", ratioPlayer2Wins * 100) + "% return\n";

                        Dictionary<string, int> supportersPlayer2 = new Dictionary<string, int>();
                        foreach (TopPredictor supporter in outcomePlayer2.top_predictors.OrderByDescending(q => q.channel_points_used).Take(3))
                            supportersPlayer2.Add(supporter.user_name, supporter.channel_points_used);
                        summary += $"Biggest {namePlayer2} believers";
                        foreach (KeyValuePair<string, int> supporter in supportersPlayer2)
                            summary += "\n" + supporter.Key + ": " + string.Format("{0:n0}", supporter.Value);
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

                        summary += string.Format("{0:n0}", totalPoints) + " wagered\n";
                        summary += string.Format("+{0:n0}", ratio * 100) + $"% return on {nameWinner}\n";
                        summary += $"\nBiggest {nameWinner} believers";
                        foreach (KeyValuePair<string, int> winner in winners)
                            summary += "\n" + winner.Key + ": +" + string.Format("{0:n0}", winner.Value);

                        summary += $"\n\nBiggest {nameWinner} doubters";
                        foreach (KeyValuePair<string, int> loser in losers)
                            summary += "\n" + loser.Key + ": -" + string.Format("{0:n0}", loser.Value);
                    }
                    return summary;
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }
    }

    public class Pagination
    {
        public string cursor { get; set; }
    }

    public class PredictionCollection
    {
        public List<Prediction> data { get; set; }
        public Pagination pagination { get; set; }
    }

    public class Param_Outcome
    {
        public string title { get; set; }
    }

    public class Param_Prediction
    {
        public string broadcaster_id { get; set; }
        public string title { get; set; }
        public List<Param_Outcome> outcomes { get; set; }
        public int prediction_window { get; set; }
    }

    public class UserCollection
    {
        public List<User> data { get; set; }
    }
    public class User
    {
        public string id { get; set; }
        public string login { get; set; }
        public string display_name { get; set; }
        public string type { get; set; }
        public string broadcaster_type { get; set; }
        public string description { get; set; }
        public string profile_image_url { get; set; }
        public string offline_image_url { get; set; }
        public int view_count { get; set; }
        public DateTime created_at { get; set; }
    }
}
