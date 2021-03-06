/*
 * APIMATICCalculator.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 on 05/03/2016
 */
 using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
		
namespace APIMATICCalculator.PCL.Models
{
    [JsonConverter(typeof(StringEnumConverter))]		
    public enum OperationTypeEnum
    {
        SUM, //Represents the sum operator
        SUBTRACT, //Represents the subtract operator
        MULTIPLY, //Represents the multiply operator
        DIVIDE, //Represents the divide operator
    }
} 