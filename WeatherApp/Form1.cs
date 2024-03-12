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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", CityInput.Text, APIKey );
                var json = web.DownloadString(url);
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = string.Format("https://openweathermap.org/img/w/" + info.weather[0].icon + ".png");
                ConLab.Text = info.weather[0].main;
                DetailsLab.Text = info.weather[0].description;
                PressureValue.Text = info.main.pressure.ToString();
                WindValue.Text = info.wind.speed.ToString();
                SunriseValue.Text = info.sys.sunrise.ToString();
                SunsetValue.Text = info.sys.sunset.ToString();
            }
        }
    }
}
