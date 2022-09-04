
namespace Authenticatie
{
    class VerificatieToken
    {
        public string Token { get; set; }
        public DateTime VerloopDatum { get; set; }

        public VerificatieToken(string token, DateTime verloopDatum)
        {
            Token = token;
            VerloopDatum = verloopDatum;
        }
    }
}