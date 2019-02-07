using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Timetable_Generator_4000x
{
    [JsonConverter(typeof(StringEnumConverter))]
    enum TimeBlockNumber
    {
        [EnumMember(Value = "1")] one = 1,
        [EnumMember(Value = "2")] two = 2,
        [EnumMember(Value = "3")] three = 3,
        [EnumMember(Value = "4")] four = 4,
        [EnumMember(Value = "5")] five = 5,
        [EnumMember(Value = "6")] six = 6,
        [EnumMember(Value = "7")] seven = 7
    }

};