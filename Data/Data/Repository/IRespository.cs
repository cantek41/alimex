using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    /// <summary>
    /// Data Katmanın dışarı haberleşme arayüzüdür
    /// database bağlantısı yapacak sınıflar
    /// bunu kullanmalıdır. 
    /// Bu interface haricinde yapılan bağlantılar
    /// tasarımı aykırı olacaktır.
    /// </summary>
    public interface IRepository
    {
        #region Public Methods

        /// <summary>
        /// IsDelete Alanını setler
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(string tableName, string id);
        /// <summary>
        /// sorgulanabilir query döner
        /// direk toList ya da cast<object> yapılırsa tüm data çekilir
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        IQueryable getAll(string tableName);

        /// <summary>
        /// Id ye göre kayıt getirir
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        object getById(string tableName, string id);

        /// <summary>
        /// kayıt Ekler
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        object Insert(string tableName, Dictionary<string, string> entity);

        /// <summary>
        /// Gelen Idye göre var olan kayıdı bulur
        /// sonra gelen datalara göre kaydı yeniler
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        object Update(string tableName, Dictionary<string, string> entity);
        /// <summary>
        /// tablodaki kayıt sayısını getirir
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        int Count(string tableName);
        /// <summary>
        /// gönderilen sql sorgusu
        /// dbden okunur JArray Tipine çevrilir
        /// geri gönderilir
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        JArray ExecuteSqlQueryJson(string sql);

        bool UpdateDb(IList<Table> table);

        IList<Table> getTables();
            
        #endregion Public Methods

    }
}