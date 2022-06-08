namespace Service
{
    public interface IProductService
    {
        int[] Reverse(ref int[] productIds);
        int[] DeletePart(int position, ref int[] productIds);
    }
}