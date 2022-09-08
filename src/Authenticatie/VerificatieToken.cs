
namespace Authenticatie
{
    public class VerificatieToken
    {
        public string Token { get; set; }
        public DateTime VerloopDatum { get; set; }

        public VerificatieToken(string token, DateTime verloopDatum)
        {
            Token = token;
            VerloopDatum = verloopDatum;
        }
        
        public bool Verifieer(string token)
        {
            if (Token == null || (Token == token && VerloopDatum <= DateTime.Now))
            {
                Console.WriteLine("verificatie voltooid");          // TODO: remove
                return true;
            }
            else return false;
        }
    }
}