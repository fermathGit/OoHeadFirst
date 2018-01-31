using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_2_weather {
    class HeadIndexDisplay : Observer, DisplayElement {
        float m_headIndex;
        Subject m_weatherData;

        public HeadIndexDisplay(Subject subject) {
            m_weatherData = subject;
            m_weatherData.RegisterObserver( this );
        }

        public void Display() {
            Console.WriteLine( string.Format( "Head index:{0}~~~", m_headIndex ) );
        }

        public void Update( float temp, float humidity, float pressure ) {
            m_headIndex = temp + humidity + pressure;
            Display();
        }

        public void Update(Subject subject) {
            WeatherData_Pull wdp = (WeatherData_Pull)subject;  //这里偷懒了  应该在接口去定义 getter 方法  反正就这个意思了
            Update( wdp.Temperature, wdp.Humidity, wdp.Pressure );
        }
    }
}
