namespace MvcTypescript.MvcWebClient.Entities
{
    public enum Gender
    {
        Male = 'M',
        /// <summary>
        /// Female gender, 'F'
        /// </summary>
        Female = 'F',
        /// <summary>
        /// Other gender, Trans-gender, Alien, Mutant, Eunuch, etc., 'O'
        /// </summary>
        //  Other = 'O',
        /// <summary>
        /// Unknown gender, 'U' (if NOT SET or afraid to ask, then use <c>null</c>, this is literally meant as unknown or not collected).
        /// </summary>
        Unknown = 'U'
    }
}