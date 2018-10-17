namespace Lab05_OOP_Zoo.Classes
{
    /// <summary>
    /// 
    /// </summary>
    abstract public class Eatable
    {
        /// <summary>
        /// Name of the eatable object
        /// </summary>
        public string Name
        {
            get => m_Name;
            set => m_Name = value;
        }
        private string m_Name;


        /// <summary>
        /// Weight of the eatable object
        /// </summary>
        public int Weight
        {
            get => m_weight;
            set => m_weight = value;
        }
        private int m_weight;


        /// <summary>
        /// Unique identifier for eatable object
        /// </summary>
        private long UID;

        /// <summary>
        /// Return Name of an object
        /// </summary>
        /// <returns>The name of the object</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
