using Newtonsoft.Json;
using System.Net;
using static System.Net.WebRequestMethods;


namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "c4b99a3f43a298ed63bf5a36911ae32c";


        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
               
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", CityInput.Text, APIKey);
               
                try
                {
                    var json = web.DownloadString(url);
                    WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    picIcon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                    ConLab.Text = info.weather[0].main;
                    DetailsLab.Text = info.weather[0].description;
                    PressureValue.Text = info.main.pressure.ToString();
                    WindValue.Text = info.wind.speed.ToString();
                    SunriseValue.Text = convertDateTime(info.sys.sunrise).ToShortTimeString();
                    SunsetValue.Text = convertDateTime(info.sys.sunset).ToShortTimeString();
                }

                catch
                {
                    throw;
                    CityInput.Text = "Invalid Location";
                }
                  

            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            getWeather();
        }

        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }
    }
}
