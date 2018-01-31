using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_2_weather {
    class WeatherData :Subject{
        List<Observer> observers;
        float m_temperature;
        float m_humidity;
        float m_pressure;

        public WeatherData() {
            observers = new List<Observer>();
        }

        public void RegisterObserver( Observer o ) {
            bool isHave = false;
            for ( int i = 0, imax = observers.Count; i < imax; ++i ) {
                if ( observers[i] == o ) {
                    isHave = true;
                    break;
                }
            }
            if ( !isHave )
                observers.Add( o );
        }

        public void RemoveObserver( Observer o ) {
            for ( int i = observers.Count - 1; i >= 0; --i ) {
                if ( observers[i] == o )
                    observers.Remove( o );
            }
        }

        public void NotifyObserver() {
            for ( int i = 0, imax = observers.Count; i < imax; ++i ) {
                observers[i].Update( m_temperature, m_humidity, m_pressure );
            }
        }

        public void MeasurementsChanged() {
            NotifyObserver();
        }

        public void SetMeasurements( float temperature, float humidity, float pressure ) {
            m_temperature = temperature;
            m_humidity = humidity;
            m_pressure = pressure;
            MeasurementsChanged();
        }
    }
}
