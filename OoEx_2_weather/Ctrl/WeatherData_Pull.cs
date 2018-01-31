using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_2_weather {
    public class WeatherData_Pull : Subject {
        List<Observer> observers;
        float m_temperature;
        float m_humidity;
        float m_pressure;

        public float Temperature { get { return m_temperature; } set { m_temperature = value; } }
        public float Humidity { get { return m_humidity; } set { m_humidity = value; } }
        public float Pressure { get { return m_pressure; } set { m_pressure = value; } }

        public WeatherData_Pull() {
            observers = new List<Observer>();
        }

        public void NotifyObserver() {
            for ( int i = 0, imax = observers.Count; i < imax; ++i ) {
                observers[i].Update( this );
            }
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
