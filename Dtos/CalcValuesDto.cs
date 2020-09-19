namespace Hypergeometric.API.Dtos
{
    public class CalcValuesDto
    {
        /**<summary>Population Size</summary>*/
        public int PS { get; set; }    
        /**<summary>Sample Size</summary>*/
        public int SS { get; set; }
        /**<summary> Successes in Population</summary>*/
        public int SIP { get; set; }
        /**<summary>Successes in Sample</summary>*/
        public int SIS { get; set; }


        public CalcValuesDto(){}
    }
}