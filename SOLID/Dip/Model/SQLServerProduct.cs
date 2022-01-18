namespace SOLID.Dip.Model
{
    class SQLServerProduct: DbProduct
    {
        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}.";
        }
    }
}
