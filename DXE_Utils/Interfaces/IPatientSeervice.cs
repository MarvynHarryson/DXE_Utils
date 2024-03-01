namespace DXE_Utils.Interfaces
{
    public interface IPatientSeervice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task InsertOnePatient();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cuantity"></param>
        /// <returns></returns>
        public Task InsertPatients(int Cuantity);
    }
}
