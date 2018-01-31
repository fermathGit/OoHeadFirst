using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_2_weather {
    public class CurrentConditionsDisplay :Observer,DisplayElement{
        float m_temperature;
        float m_humidity;
        Subject m_weatherData;

        public CurrentConditionsDisplay( Subject weatherData ) {
            m_weatherData = weatherData;
            weatherData.RegisterObserver( this );
        }

        public void Update( float temp, float humidity, float pressure ) {
            m_temperature = temp;
            m_humidity = humidity;
            Display();
        }

        public void Display() {
            Console.WriteLine( string.Format( "Current conditions:{0}F degrees and {1}% humidity", m_temperature, m_humidity ) );
        }
        
        public void Update( Subject subject ) {
            WeatherData_Pull wdp = (WeatherData_Pull)subject;
            Update( wdp.Temperature, wdp.Humidity, wdp.Pressure );
        }
    }
}
