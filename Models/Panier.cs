public class Panier
{
    public int PanierId { get; set; }
    public int UserId { get; set; }
    public DateTime CreationDate { get; set; }
    public List<PanierItem> PanierItems { get; set; }
    public Consomateur Consomateur { get; set; }
}