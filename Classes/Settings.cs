namespace Aquarius
{
    public class Settings
    {
        public string TwitchChannel { get; set; }
        public string TwitchToken { get; set; }
        public string TwitchClientId { get; set; }
        public int PortNumber { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string BackgroundColor { get; set; }
        public string FontColor { get; set; }
        public int FontSize { get; set; }
        public string FontFamily { get; set; }
        public int BorderWidth { get; set; }
        public string BorderColor { get; set; }
        public int DisplayDuration { get; set; }
        public int TransitionDuration { get; set; }
        public bool RefreshOnLoad { get; set; }
        public bool RefreshOnTimer { get; set; }
        public int RefreshTimerDuration { get; set; }
        public int BettorsToDisplay { get; set; }
        public string TemplateDoubleActive { get; set; }
        public string TemplateDoubleLocked { get; set; }
        public string TemplateDoubleCanceled { get; set; }
        public string TemplateDoubleResolved { get; set; }
        public string TemplateSingleActive { get; set; }
        public string TemplateSingleLocked { get; set; }
        public string TemplateSingleCanceled { get; set; }
        public string TemplateSingleResolved { get; set; }

        public Settings()
        {
            TwitchChannel = "";
            TwitchToken = "";
            TwitchClientId = "";
            PortNumber = 8081;
            Width = 500;
            Height = 500;
            BackgroundColor = "#333333";
            FontColor = "White";
            FontSize = 30;
            FontFamily = "Roboto";
            BorderWidth = 9;
            BorderColor = "#8000FF";
            DisplayDuration = 0;
            TransitionDuration = 1000;
            RefreshOnLoad = true;
            RefreshOnTimer = true;
            RefreshTimerDuration = 10000;
            BettorsToDisplay = 3;
            TemplateDoubleActive = $"Bet active, {TemplateFields.FIELD_POINTS_TOTAL} wagered<br><br>{TemplateFields.FIELD_POINTS_A} on {TemplateFields.FIELD_NAME_A}, {TemplateFields.FIELD_RETURN_A}% return<br>Biggest {TemplateFields.FIELD_NAME_A} believers<br>{TemplateFields.FIELD_TOP_BETTERS_A}<br><br>{TemplateFields.FIELD_POINTS_B} on {TemplateFields.FIELD_NAME_B}, {TemplateFields.FIELD_RETURN_B}% return<br>Biggest {TemplateFields.FIELD_NAME_B} believers<br>{TemplateFields.FIELD_TOP_BETTERS_B}";
            TemplateDoubleLocked = $"Bet locked, {TemplateFields.FIELD_POINTS_TOTAL} wagered<br><br>{TemplateFields.FIELD_POINTS_A} on {TemplateFields.FIELD_NAME_A}, {TemplateFields.FIELD_RETURN_A}% return<br>Biggest {TemplateFields.FIELD_NAME_A} believers<br>{TemplateFields.FIELD_TOP_BETTERS_A}<br><br>{TemplateFields.FIELD_POINTS_B} on {TemplateFields.FIELD_NAME_B}, {TemplateFields.FIELD_RETURN_B}% return<br>Biggest {TemplateFields.FIELD_NAME_B} believers<br>{TemplateFields.FIELD_TOP_BETTERS_B}";
            TemplateDoubleCanceled = $"Bet cancelled, points refunded";
            TemplateDoubleResolved = $"Bet resolved, {TemplateFields.FIELD_POINTS_TOTAL} wagered<br><br>{TemplateFields.FIELD_POINTS_A} on {TemplateFields.FIELD_NAME_A}, {TemplateFields.FIELD_RETURN_A}% return<br>Biggest {TemplateFields.FIELD_NAME_A} believers<br>{TemplateFields.FIELD_TOP_BETTERS_A}<br><br>{TemplateFields.FIELD_POINTS_B} on {TemplateFields.FIELD_NAME_B}<br>Biggest {TemplateFields.FIELD_NAME_A} doubters<br>{TemplateFields.FIELD_TOP_BETTERS_B}";
            TemplateSingleActive = $"Total Wager<br>{TemplateFields.FIELD_POINTS_A}<br><br>Payout<br>{TemplateFields.FIELD_RETURN_A}%<br><br>Biggest believers<br>{TemplateFields.FIELD_TOP_BETTERS_A}";
            TemplateSingleLocked = $"Total Wager<br>{TemplateFields.FIELD_POINTS_A}<br><br>Payout<br>{TemplateFields.FIELD_RETURN_A}%<br><br>Biggest believers<br>{TemplateFields.FIELD_TOP_BETTERS_A}";
            TemplateSingleCanceled = $"Bet cancelled, points refunded";
            TemplateSingleResolved = $"Total Wager<br>{TemplateFields.FIELD_POINTS_A}<br><br>Payout<br>{TemplateFields.FIELD_RETURN_A}%<br><br>Biggest believers<br>{TemplateFields.FIELD_TOP_BETTERS_A}";
        }
    }
}