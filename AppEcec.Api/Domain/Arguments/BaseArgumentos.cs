using Newtonsoft.Json;
using System;

namespace Domain.Arguments
{
    public class BaseArgumentos
    {
        public String Menssagem { get; set; }

        public Boolean Error { get; set; }

        public Guid IdSessao { get; set; }

        public object Alertas { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
