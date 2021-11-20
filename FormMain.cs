using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace Aquarius
{
    public partial class FormMain : Form
    {
        private bool _ReInitializeTwitch = false;
        private bool _ReInitializeOverlay = false;
        private static readonly log4net.ILog _Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public FormMain()
        {
            InitializeComponent();

            LoadSettings();
            InitializeTwitch();
            InitializeOverlay();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            OverlayManager.Instance.RefreshActiveWebSockets();
        }

        private void controlBasic_Changed(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void controlTwitch_Changed(object sender, EventArgs e)
        {
            _ReInitializeTwitch = true;
            buttonApply.Enabled = true;
        }

        private void controlOverlay_Changed(object sender, EventArgs e)
        {
            _ReInitializeOverlay = true;
            buttonApply.Enabled = true;
        }

        private void buttonBackgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color c = colorDialog.Color;
                textBoxBackgroundColor.Text = ColorTranslator.ToHtml(c);
            }
        }

        private void textBoxBackgroundColor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonApply.Enabled = true;
                buttonBackgroundColor.BackColor = ColorTranslator.FromHtml(textBoxBackgroundColor.Text);
            }
            catch (Exception)
            {
                buttonBackgroundColor.BackColor = Color.White;
            }
        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color c = colorDialog.Color;
                textBoxFontColor.Text = ColorTranslator.ToHtml(c);
            }
        }

        private void textBoxFontColor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonApply.Enabled = true;
                buttonFontColor.BackColor = ColorTranslator.FromHtml(textBoxFontColor.Text);
            }
            catch (Exception)
            {
                buttonFontColor.BackColor = Color.Black;
            }
        }

        private void buttonBorderColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color c = colorDialog.Color;
                textBoxBorderColor.Text = ColorTranslator.ToHtml(c);
            }
        }

        private void textBoxBorderColor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonApply.Enabled = true;
                buttonBorderColor.BackColor = ColorTranslator.FromHtml(textBoxBorderColor.Text);
            }
            catch (Exception)
            {
                buttonBorderColor.BackColor = Color.Black;
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            OverlayManager.Instance.RefreshActiveWebSockets();
        }

        private void linkLabelOpenPanelPreview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = $"file:///{Environment.CurrentDirectory.Replace("\\", "/")}/Pages/{comboBoxPanelPreview.Text}.html";
            System.Diagnostics.Process.Start(path);
        }

        private void LoadSettings()
        {
            try
            {
                textBoxTwitchChannel.Text = SettingsManager.Instance.Settings.TwitchChannel;
                textBoxTwitchToken.Text = SettingsManager.Instance.Settings.TwitchToken;
                textBoxTwitchClientID.Text = SettingsManager.Instance.Settings.TwitchClientId;
                numericUpDownWidth.Text = SettingsManager.Instance.Settings.Width.ToString();
                numericUpDownHeight.Text = SettingsManager.Instance.Settings.Height.ToString();
                textBoxBackgroundColor.Text = SettingsManager.Instance.Settings.BackgroundColor;
                numericUpDownFontSize.Value = SettingsManager.Instance.Settings.FontSize;
                textBoxFontColor.Text = SettingsManager.Instance.Settings.FontColor;
                comboBoxFontFamily.Text = SettingsManager.Instance.Settings.FontFamily;
                numericUpDownBorderWidth.Value = SettingsManager.Instance.Settings.BorderWidth;
                textBoxBorderColor.Text = SettingsManager.Instance.Settings.BorderColor;
                numericUpDownDisplayDuration.Value = SettingsManager.Instance.Settings.DisplayDuration;
                numericUpDownTransitionDuration.Value = SettingsManager.Instance.Settings.TransitionDuration;
                numericUpDownPortNumber.Value = SettingsManager.Instance.Settings.PortNumber;
                checkBoxRefreshOnLoad.Checked = SettingsManager.Instance.Settings.RefreshOnLoad;
                checkBoxRefreshOnTimer.Checked = SettingsManager.Instance.Settings.RefreshOnTimer;
                numericUpDownRefreshTimerDuration.Value = SettingsManager.Instance.Settings.RefreshTimerDuration;

                comboBoxFontFamily.Items.Clear();
                foreach (FontFamily ff in FontFamily.Families)
                    comboBoxFontFamily.Items.Add(ff.Name);

                comboBoxPanelPreview.Items.Clear();
                foreach (string page in Directory.EnumerateFiles("Pages", "*.html", SearchOption.TopDirectoryOnly))
                    comboBoxPanelPreview.Items.Add(Path.GetFileNameWithoutExtension(page));
                if (comboBoxPanelPreview.Items.Count > 0)
                    comboBoxPanelPreview.SelectedIndex = comboBoxPanelPreview.Items.Count - 1;

                UpdateTimer();

                _ReInitializeTwitch = false;
                _ReInitializeOverlay = false;
                buttonApply.Enabled = false;
            }
            catch (Exception ex)
            {
                _Log.Error("Exception in FormMain.LoadSettings: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveSettings()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();

                Settings settings = SettingsManager.Instance.Settings;
                settings.TwitchChannel = textBoxTwitchChannel.Text;
                settings.TwitchToken = textBoxTwitchToken.Text;
                settings.TwitchClientId = textBoxTwitchClientID.Text;
                settings.Width = (int)numericUpDownWidth.Value;
                settings.Height = (int)numericUpDownHeight.Value;
                settings.BackgroundColor = textBoxBackgroundColor.Text;
                settings.FontSize = (int)numericUpDownFontSize.Value;
                settings.FontColor = textBoxFontColor.Text;
                settings.FontFamily = comboBoxFontFamily.Text;
                settings.BorderWidth = (int)numericUpDownBorderWidth.Value;
                settings.BorderColor = textBoxBorderColor.Text;
                settings.DisplayDuration = (int)numericUpDownDisplayDuration.Value;
                settings.TransitionDuration = (int)numericUpDownTransitionDuration.Value;
                settings.PortNumber = int.Parse(numericUpDownPortNumber.Text);
                settings.RefreshOnLoad = checkBoxRefreshOnLoad.Checked;
                settings.RefreshOnTimer = checkBoxRefreshOnTimer.Checked;
                settings.RefreshTimerDuration = (int)numericUpDownRefreshTimerDuration.Value;
                SettingsManager.Instance.SaveSettings(settings);

                if (_ReInitializeTwitch)
                    TwitchManager.Instance.Initialize();

                if (_ReInitializeOverlay)
                    OverlayManager.Instance.Initialize();

                UpdateTimer();

                _ReInitializeTwitch = false;
                _ReInitializeOverlay = false;
                buttonApply.Enabled = false;
            }
            catch (Exception ex)
            {
                _Log.Error("Exception in FormMain.SaveSettings: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void InitializeTwitch()
        {
            try
            {
                TwitchManager.Instance.Initialize();
            }
            catch (Exception ex)
            {
                _Log.Error("Exception in FormMain.InitializeTwitch: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeOverlay()
        {
            try
            {
                OverlayManager.Instance.Initialize();
            }
            catch (Exception ex)
            {
                _Log.Error("Exception in FormMain.InitializeOverlay: " + ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateTimer()
        {
            if (SettingsManager.Instance.Settings.RefreshOnTimer)
            {
                timerRefresh.Stop();

                timerRefresh.Interval = SettingsManager.Instance.Settings.RefreshTimerDuration;
                timerRefresh.Start();
            }
            else
            {
                timerRefresh.Stop();
            }
        }
    }
}
