//------------------------------------------------------------------------------
// <auto-generated>
//     此代码从T4模板生成。
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------
using SqlSugar;
using System;

namespace JZ.Models
{
    /// <summary>	
    /// 数据表实体类： (Test)
    /// </summary>
    [SugarTable("Test")][Serializable]
    public partial class Test:BaseEntity
    {       
        private int _id ;
        /// <summary>
        ///  
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,IsIdentity = true)]
        public  int id 
        {
            get
            {
            	return this._id;
            }
            set
            {
            	if (this._id != value)
            	{
            		base.SetValueCall("id", this._id);
            	}
            	this._id = value;
            }
         }
        private string _Value ;
        /// <summary>
        ///  
        /// </summary>
        
        public  string Value 
        {
            get
            {
            	return this._Value;
            }
            set
            {
            	if (this._Value != value)
            	{
            		base.SetValueCall("Value", this._Value);
            	}
            	this._Value = value;
            }
         }
 
    }
}

