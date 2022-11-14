using System.ComponentModel;

namespace DataGridView_Adm_Com_NuGet.Models
{
    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Мужской
        /// </summary>
        [Description("Мужской")]
        Male,
        /// <summary>
        /// Женский
        /// </summary>
        [Description("Женский")]
        Female
    }
}
