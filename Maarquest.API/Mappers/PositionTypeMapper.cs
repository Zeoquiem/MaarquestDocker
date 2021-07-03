using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class PositionTypeMapper
    {
        public static PositionType ConvertToPositionType(POSITION_TYPE data)
        {
            PositionType result = null;
            if (data != null)
            {
                result = new PositionType()
                {
                    PositionTypeId = data.POSITION_TYPE_ID,
                    Label = data.LABEL
                };
            }
            return result;
        }
        public static POSITION_TYPE ConvertToPOSITION_TYPE(PositionType data)
        {
            POSITION_TYPE result = null;
            if (data != null)
            {
                result = new POSITION_TYPE()
                {
                    POSITION_TYPE_ID = data.PositionTypeId,
                    LABEL = data.Label

                };
            }
            return result;
        }

        public static List<PositionType> ConvertToPositionTypeList(List<POSITION_TYPE> datas)
        {
            List<PositionType> result = new List<PositionType>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PositionType pt = ConvertToPositionType(data);
                    result.Add(pt);
                }
            }
            return result;
        }

        public static List<POSITION_TYPE> ConvertToPOSITION_TYPEList(List<PositionType> datas)
        {
            List<POSITION_TYPE> result = new List<POSITION_TYPE>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    POSITION_TYPE pt = ConvertToPOSITION_TYPE(data);
                    result.Add(pt);
                }
            }
            return result;
        }

    }
}

