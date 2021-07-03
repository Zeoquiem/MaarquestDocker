using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;


namespace Maarquest.API.Mappers
{
    class TransportMeanMapper
    {
        public static TransportMean ConvertToTransportMean(TRANSPORT_MEAN data)
        {
            TransportMean result = null;
            if (data != null)
            {
                result = new TransportMean()
                {
                    TransportMeanId = data.TRANSPORT_MEAN_ID,
                    Label = data.LABEL,
                    CarbonFootprint = data.CARBON_FOOTPRINT
                };
            }
            return result;
        }
        public static TRANSPORT_MEAN ConvertToTRANSPORT_MEAN(TransportMean data)
        {
            TRANSPORT_MEAN result = null;
            if (data != null)
            {
                result = new TRANSPORT_MEAN()
                {
                    TRANSPORT_MEAN_ID = data.TransportMeanId,
                    LABEL= data.Label,
                    CARBON_FOOTPRINT= data.CarbonFootprint

                };
            }
            return result;
        }

        public static List<TransportMean> ConvertToTransportMeanList(List<TRANSPORT_MEAN> datas)
        {
            List<TransportMean> result = new List<TransportMean>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    TransportMean tm = ConvertToTransportMean(data);
                    result.Add(tm);
                }
            }
            return result;
        }

        public static List<TRANSPORT_MEAN> ConvertToDELIVERYList(List<TransportMean> datas)
        {
            List<TRANSPORT_MEAN> result = new List<TRANSPORT_MEAN>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    TRANSPORT_MEAN tm = ConvertToTRANSPORT_MEAN(data);
                    result.Add(tm);
                }
            }
            return result;
        }
    }
}
