namespace api.Models
{
    public class BoardCell
    {
    public int Id { get; set; }
    public Board Board { get; set; }

    public int CellId { get; set; }
    public Cell Cells { get; set; }
    }
}

