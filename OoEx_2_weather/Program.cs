using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_2_weather {
    class Program {
        static void Main( string[] args ) {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay( weatherData );
            HeadIndexDisplay hid = new HeadIndexDisplay( weatherData );

            WeatherData_Pull weatherDataPull = new WeatherData_Pull();
            CurrentConditionsDisplay ccd2 = new CurrentConditionsDisplay( weatherDataPull );
            HeadIndexDisplay hid2 = new HeadIndexDisplay( weatherDataPull );

            weatherData.SetMeasurements( 80, 64, 30.4f );
            weatherDataPull.SetMeasurements( 80, 64, 30.4f );

            Console.Read();
        }
    }
}
