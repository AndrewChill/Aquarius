using System.Collections.Generic;
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
