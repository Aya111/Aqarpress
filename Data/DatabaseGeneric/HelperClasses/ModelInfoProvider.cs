﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.4.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using AqarPress.Data.FactoryClasses;
using AqarPress.Data.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AqarPress.Data.HelperClasses
{
	/// <summary>Singleton implementation of the ModelInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	public static class ModelInfoProviderSingleton
	{
		private static readonly IModelInfoProvider _providerInstance = new ModelInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static ModelInfoProviderSingleton()	{ }

		/// <summary>Gets the singleton instance of the ModelInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IModelInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the ModelInfoProvider.</summary>
	internal class ModelInfoProviderCore : ModelInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="ModelInfoProviderCore"/> class.</summary>
		internal ModelInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitAreaEntityInfo();
			InitCategoryEntityInfo();
			InitDeveloperEntityInfo();
			InitProjectEntityInfo();
			InitProjectDiscussionEntityInfo();
			InitProjectSubCategoryTableEntityInfo();
			InitRoleEntityInfo();
			InitSubCategoryEntityInfo();
			InitUserEntityInfo();
			this.BuildInternalStructures();
		}

		/// <summary>Inits AreaEntity's info objects</summary>
		private void InitAreaEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(AreaFieldIndex), "AreaEntity");
			this.AddElementFieldInfo("AreaEntity", "ArabicName", typeof(System.String), false, false, false, false,  (int)AreaFieldIndex.ArabicName, 500, 0, 0);
			this.AddElementFieldInfo("AreaEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)AreaFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("AreaEntity", "Name", typeof(System.String), false, false, false, false,  (int)AreaFieldIndex.Name, 500, 0, 0);
		}

		/// <summary>Inits CategoryEntity's info objects</summary>
		private void InitCategoryEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(CategoryFieldIndex), "CategoryEntity");
			this.AddElementFieldInfo("CategoryEntity", "ArabicName", typeof(System.String), false, false, false, false,  (int)CategoryFieldIndex.ArabicName, 500, 0, 0);
			this.AddElementFieldInfo("CategoryEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)CategoryFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("CategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)CategoryFieldIndex.Name, 500, 0, 0);
		}

		/// <summary>Inits DeveloperEntity's info objects</summary>
		private void InitDeveloperEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(DeveloperFieldIndex), "DeveloperEntity");
			this.AddElementFieldInfo("DeveloperEntity", "ArabicName", typeof(System.String), false, false, false, false,  (int)DeveloperFieldIndex.ArabicName, 500, 0, 0);
			this.AddElementFieldInfo("DeveloperEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)DeveloperFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("DeveloperEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)DeveloperFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("DeveloperEntity", "Name", typeof(System.String), false, false, false, false,  (int)DeveloperFieldIndex.Name, 500, 0, 0);
			this.AddElementFieldInfo("DeveloperEntity", "Path", typeof(System.String), false, false, false, false,  (int)DeveloperFieldIndex.Path, 100, 0, 0);
		}

		/// <summary>Inits ProjectEntity's info objects</summary>
		private void InitProjectEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProjectFieldIndex), "ProjectEntity");
			this.AddElementFieldInfo("ProjectEntity", "ArabicName", typeof(System.String), false, false, false, false,  (int)ProjectFieldIndex.ArabicName, 500, 0, 0);
			this.AddElementFieldInfo("ProjectEntity", "CategoryId", typeof(System.Int32), false, true, false, false,  (int)ProjectFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("ProjectEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)ProjectFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("ProjectEntity", "DeveloperId", typeof(System.Int32), false, true, false, false,  (int)ProjectFieldIndex.DeveloperId, 0, 0, 10);
			this.AddElementFieldInfo("ProjectEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)ProjectFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("ProjectEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)ProjectFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("ProjectEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProjectFieldIndex.Name, 500, 0, 0);
			this.AddElementFieldInfo("ProjectEntity", "Path", typeof(System.String), false, false, false, false,  (int)ProjectFieldIndex.Path, 100, 0, 0);
		}

		/// <summary>Inits ProjectDiscussionEntity's info objects</summary>
		private void InitProjectDiscussionEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProjectDiscussionFieldIndex), "ProjectDiscussionEntity");
			this.AddElementFieldInfo("ProjectDiscussionEntity", "CommenterId", typeof(System.Int32), false, true, false, false,  (int)ProjectDiscussionFieldIndex.CommenterId, 0, 0, 10);
			this.AddElementFieldInfo("ProjectDiscussionEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)ProjectDiscussionFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("ProjectDiscussionEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)ProjectDiscussionFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("ProjectDiscussionEntity", "MessageBody", typeof(System.String), false, false, false, false,  (int)ProjectDiscussionFieldIndex.MessageBody, 500, 0, 0);
			this.AddElementFieldInfo("ProjectDiscussionEntity", "ProjectId", typeof(System.Int32), false, true, false, false,  (int)ProjectDiscussionFieldIndex.ProjectId, 0, 0, 10);
		}

		/// <summary>Inits ProjectSubCategoryTableEntity's info objects</summary>
		private void InitProjectSubCategoryTableEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProjectSubCategoryTableFieldIndex), "ProjectSubCategoryTableEntity");
			this.AddElementFieldInfo("ProjectSubCategoryTableEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)ProjectSubCategoryTableFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("ProjectSubCategoryTableEntity", "ProjectId", typeof(System.Int32), false, true, false, false,  (int)ProjectSubCategoryTableFieldIndex.ProjectId, 0, 0, 10);
			this.AddElementFieldInfo("ProjectSubCategoryTableEntity", "SubCategoryId", typeof(System.Int32), false, true, false, false,  (int)ProjectSubCategoryTableFieldIndex.SubCategoryId, 0, 0, 10);
		}

		/// <summary>Inits RoleEntity's info objects</summary>
		private void InitRoleEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(RoleFieldIndex), "RoleEntity");
			this.AddElementFieldInfo("RoleEntity", "Id", typeof(System.Int32), true, false, false, false,  (int)RoleFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("RoleEntity", "Name", typeof(System.String), false, false, false, false,  (int)RoleFieldIndex.Name, 500, 0, 0);
		}

		/// <summary>Inits SubCategoryEntity's info objects</summary>
		private void InitSubCategoryEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(SubCategoryFieldIndex), "SubCategoryEntity");
			this.AddElementFieldInfo("SubCategoryEntity", "ArabicName", typeof(System.String), false, false, false, false,  (int)SubCategoryFieldIndex.ArabicName, 500, 0, 0);
			this.AddElementFieldInfo("SubCategoryEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)SubCategoryFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("SubCategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)SubCategoryFieldIndex.Name, 500, 0, 0);
		}

		/// <summary>Inits UserEntity's info objects</summary>
		private void InitUserEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)UserFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "DeviceToken", typeof(System.String), false, false, false, true,  (int)UserFieldIndex.DeviceToken, 100, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Id", typeof(System.Int32), true, false, false, false,  (int)UserFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("UserEntity", "LastLoginDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)UserFieldIndex.LastLoginDate, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "MobilePhone", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.MobilePhone, 50, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Name", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Name, 500, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 500, 0, 0);
			this.AddElementFieldInfo("UserEntity", "RoleId", typeof(System.Int32), false, true, false, false,  (int)UserFieldIndex.RoleId, 0, 0, 10);
		}
	}
}