using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {

        float lat;
        float lon;
        float maxtem;
        float mintem;
        float winsp;
        string URL;
        Stream responseStream;

        public Form1()
        {
            InitializeComponent();
        }

        //実行ボタンクリック
        private void startButton_Click(object sender, EventArgs e)
        {
            parameters();
            generationURL();
        }

        //パラメータ取得
        public void parameters()
        {
            lat = float.Parse(latBox.Text);
            lon = float.Parse(lonBox.Text);
            
           
        }

        //URLの生成
        public void generationURL()
        {
            URL = "https://api.open-meteo.com/v1/forecast?latitude=" + lat + "&longitude=" + lon;

            //チェックボックスが1つ以上選択されているかどうか
            if(maxtemCheckBox.Checked == true|| mintemCheckBox.Checked == true|| winspCheckBox.Checked == true)
            {
                URL = URL + "&daily=";

                //最高気温チェックボックスチェック
                if(maxtemCheckBox.Checked == true)
                {
                    URL = URL + "temperature_2m_max,";
                }

                //最低気温チェックボックスチェック
                if(mintemCheckBox.Checked == true)
                {
                    URL = URL + "temperature_2m_min,";
                }

                //風速チェックボックスチェック
                if(winspCheckBox.Checked == true)
                {
                    URL = URL + "wind_speed_10m_max,";
                }
            }

            //URL最後尾のコンマの削除
            URL = URL.TrimEnd(',');
            Console.WriteLine(URL);
            Console.ReadLine();

            //タイムゾーン設定、東京固定
            URL = URL + "&timezone=Asia%2FTokyo";

        }

        //URLの取得
        public void accessURL()
        {
            WebRequest request = WebRequest.Create(URL);
            responseStream = request.GetResponse().GetResponseStream();
        }

        //天気情報取得、表示
        public void getInformationView()
        {
            StreamReader reader = new StreamReader(responseStream);
            var obj_from_json = JObject.Parse(reader.ReadToEnd());

            var getTimezone = obj_from_json["timezone"];
            if (maxtemCheckBox.Checked == true)
            {

                var forecast_timezone_abbreviation = obj_from_json["timezone_abbreviation"];
                var forecast_latitude = obj_from_json["latitude"];
                var forecast_longitude = obj_from_json["longitude"];
                var forecast_hourly_units = obj_from_json["hourly_units"]["temperature_2m"];
            }

            if (mintemCheckBox.Checked == true)
            {
                var forecast_timezone = obj_from_json["timezone"];
                var forecast_timezone_abbreviation = obj_from_json["timezone_abbreviation"];
                var forecast_latitude = obj_from_json["latitude"];
                var forecast_longitude = obj_from_json["longitude"];
                var forecast_hourly_units = obj_from_json["hourly_units"]["temperature_2m"];
            }

            if (winspCheckBox.Checked == true)
            {
                var forecast_timezone = obj_from_json["timezone"];
                var forecast_timezone_abbreviation = obj_from_json["timezone_abbreviation"];
                var forecast_latitude = obj_from_json["latitude"];
                var forecast_longitude = obj_from_json["longitude"];
                var forecast_hourly_units = obj_from_json["hourly_units"]["temperature_2m"];
            }
        }

    }

            
}
