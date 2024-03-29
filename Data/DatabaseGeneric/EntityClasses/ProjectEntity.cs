﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using DB_A4D6F8_AqarPress.Data.HelperClasses;
using DB_A4D6F8_AqarPress.Data.FactoryClasses;
using DB_A4D6F8_AqarPress.Data.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DB_A4D6F8_AqarPress.Data.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Project'.<br/><br/></summary>
	[Serializable]
	public partial class ProjectEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<ProjectDiscussionEntity> _projectDiscussions;
		private EntityCollection<ProjectSubCategoryTableEntity> _projectSubCategoryTables;
		private CategoryEntity _category;
		private DeveloperEntity _developer;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ProjectEntityStaticMetaData _staticMetaData = new ProjectEntityStaticMetaData();
		private static ProjectRelations _relationsFactory = new ProjectRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Category</summary>
			public static readonly string Category = "Category";
			/// <summary>Member name Developer</summary>
			public static readonly string Developer = "Developer";
			/// <summary>Member name ProjectDiscussions</summary>
			public static readonly string ProjectDiscussions = "ProjectDiscussions";
			/// <summary>Member name ProjectSubCategoryTables</summary>
			public static readonly string ProjectSubCategoryTables = "ProjectSubCategoryTables";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProjectEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProjectEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProjectEntity", InheritanceHierarchyType.None, false, (int)DB_A4D6F8_AqarPress.Data.EntityType.ProjectEntity, typeof(ProjectEntity), typeof(ProjectEntityFactory), false);
				AddNavigatorMetaData<ProjectEntity, EntityCollection<ProjectDiscussionEntity>>("ProjectDiscussions", a => a._projectDiscussions, (a, b) => a._projectDiscussions = b, a => a.ProjectDiscussions, () => new ProjectRelations().ProjectDiscussionEntityUsingProjectId, typeof(ProjectDiscussionEntity), (int)DB_A4D6F8_AqarPress.Data.EntityType.ProjectDiscussionEntity);
				AddNavigatorMetaData<ProjectEntity, EntityCollection<ProjectSubCategoryTableEntity>>("ProjectSubCategoryTables", a => a._projectSubCategoryTables, (a, b) => a._projectSubCategoryTables = b, a => a.ProjectSubCategoryTables, () => new ProjectRelations().ProjectSubCategoryTableEntityUsingProjectId, typeof(ProjectSubCategoryTableEntity), (int)DB_A4D6F8_AqarPress.Data.EntityType.ProjectSubCategoryTableEntity);
				AddNavigatorMetaData<ProjectEntity, CategoryEntity>("Category", "Projects", (a, b) => a._category = b, a => a._category, (a, b) => a.Category = b, DB_A4D6F8_AqarPress.Data.RelationClasses.StaticProjectRelations.CategoryEntityUsingCategoryIdStatic, ()=>new ProjectRelations().CategoryEntityUsingCategoryId, null, new int[] { (int)ProjectFieldIndex.CategoryId }, null, true, (int)DB_A4D6F8_AqarPress.Data.EntityType.CategoryEntity);
				AddNavigatorMetaData<ProjectEntity, DeveloperEntity>("Developer", "Projects", (a, b) => a._developer = b, a => a._developer, (a, b) => a.Developer = b, DB_A4D6F8_AqarPress.Data.RelationClasses.StaticProjectRelations.DeveloperEntityUsingDeveloperIdStatic, ()=>new ProjectRelations().DeveloperEntityUsingDeveloperId, null, new int[] { (int)ProjectFieldIndex.DeveloperId }, null, true, (int)DB_A4D6F8_AqarPress.Data.EntityType.DeveloperEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProjectEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProjectEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProjectEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProjectEntity</param>
		public ProjectEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Project which data should be fetched into this Project object</param>
		public ProjectEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Project which data should be fetched into this Project object</param>
		/// <param name="validator">The custom validator object for this ProjectEntity</param>
		public ProjectEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProjectEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProjectDiscussion' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProjectDiscussions() { return CreateRelationInfoForNavigator("ProjectDiscussions"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProjectSubCategoryTable' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProjectSubCategoryTables() { return CreateRelationInfoForNavigator("ProjectSubCategoryTables"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Category' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCategory() { return CreateRelationInfoForNavigator("Category"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Developer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeveloper() { return CreateRelationInfoForNavigator("Developer"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ProjectEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static ProjectRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProjectDiscussion' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProjectDiscussions { get { return _staticMetaData.GetPrefetchPathElement("ProjectDiscussions", CommonEntityBase.CreateEntityCollection<ProjectDiscussionEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProjectSubCategoryTable' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProjectSubCategoryTables { get { return _staticMetaData.GetPrefetchPathElement("ProjectSubCategoryTables", CommonEntityBase.CreateEntityCollection<ProjectSubCategoryTableEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Category' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCategory { get { return _staticMetaData.GetPrefetchPathElement("Category", CommonEntityBase.CreateEntityCollection<CategoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Developer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeveloper { get { return _staticMetaData.GetPrefetchPathElement("Developer", CommonEntityBase.CreateEntityCollection<DeveloperEntity>()); } }

		/// <summary>The ArabicName property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Project"."arabic_name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ArabicName
		{
			get { return (System.String)GetValue((int)ProjectFieldIndex.ArabicName, true); }
			set	{ SetValue((int)ProjectFieldIndex.ArabicName, value); }
		}

		/// <summary>The CategoryId property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Project"."category_id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CategoryId
		{
			get { return (System.Int32)GetValue((int)ProjectFieldIndex.CategoryId, true); }
			set	{ SetValue((int)ProjectFieldIndex.CategoryId, value); }
		}

		/// <summary>The DateCreated property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Project"."date_created".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)ProjectFieldIndex.DateCreated, true); }
			set	{ SetValue((int)ProjectFieldIndex.DateCreated, value); }
		}

		/// <summary>The DeveloperId property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Project"."developer_id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DeveloperId
		{
			get { return (System.Int32)GetValue((int)ProjectFieldIndex.DeveloperId, true); }
			set	{ SetValue((int)ProjectFieldIndex.DeveloperId, value); }
		}

		/// <summary>The Id property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Project"."id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)ProjectFieldIndex.Id, true); }
			set { SetValue((int)ProjectFieldIndex.Id, value); }		}

		/// <summary>The IsActive property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Project"."is_active".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)ProjectFieldIndex.IsActive, true); }
			set	{ SetValue((int)ProjectFieldIndex.IsActive, value); }
		}

		/// <summary>The Name property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Project"."name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProjectFieldIndex.Name, true); }
			set	{ SetValue((int)ProjectFieldIndex.Name, value); }
		}

		/// <summary>The Path property of the Entity Project<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Project"."path".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Path
		{
			get { return (System.String)GetValue((int)ProjectFieldIndex.Path, true); }
			set	{ SetValue((int)ProjectFieldIndex.Path, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'ProjectDiscussionEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProjectDiscussionEntity))]
		public virtual EntityCollection<ProjectDiscussionEntity> ProjectDiscussions { get { return GetOrCreateEntityCollection<ProjectDiscussionEntity, ProjectDiscussionEntityFactory>("Project", true, false, ref _projectDiscussions); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'ProjectSubCategoryTableEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProjectSubCategoryTableEntity))]
		public virtual EntityCollection<ProjectSubCategoryTableEntity> ProjectSubCategoryTables { get { return GetOrCreateEntityCollection<ProjectSubCategoryTableEntity, ProjectSubCategoryTableEntityFactory>("Project", true, false, ref _projectSubCategoryTables); } }

		/// <summary>Gets / sets related entity of type 'CategoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CategoryEntity Category
		{
			get { return _category; }
			set { SetSingleRelatedEntityNavigator(value, "Category"); }
		}

		/// <summary>Gets / sets related entity of type 'DeveloperEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual DeveloperEntity Developer
		{
			get { return _developer; }
			set { SetSingleRelatedEntityNavigator(value, "Developer"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace DB_A4D6F8_AqarPress.Data
{
	public enum ProjectFieldIndex
	{
		///<summary>ArabicName. </summary>
		ArabicName,
		///<summary>CategoryId. </summary>
		CategoryId,
		///<summary>DateCreated. </summary>
		DateCreated,
		///<summary>DeveloperId. </summary>
		DeveloperId,
		///<summary>Id. </summary>
		Id,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>Name. </summary>
		Name,
		///<summary>Path. </summary>
		Path,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace DB_A4D6F8_AqarPress.Data.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Project. </summary>
	public partial class ProjectRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between ProjectEntity and ProjectDiscussionEntity over the 1:n relation they have, using the relation between the fields: Project.Id - ProjectDiscussion.ProjectId</summary>
		public virtual IEntityRelation ProjectDiscussionEntityUsingProjectId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProjectDiscussions", true, new[] { ProjectFields.Id, ProjectDiscussionFields.ProjectId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProjectEntity and ProjectSubCategoryTableEntity over the 1:n relation they have, using the relation between the fields: Project.Id - ProjectSubCategoryTable.ProjectId</summary>
		public virtual IEntityRelation ProjectSubCategoryTableEntityUsingProjectId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProjectSubCategoryTables", true, new[] { ProjectFields.Id, ProjectSubCategoryTableFields.ProjectId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProjectEntity and CategoryEntity over the m:1 relation they have, using the relation between the fields: Project.CategoryId - Category.Id</summary>
		public virtual IEntityRelation CategoryEntityUsingCategoryId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Category", false, new[] { CategoryFields.Id, ProjectFields.CategoryId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProjectEntity and DeveloperEntity over the m:1 relation they have, using the relation between the fields: Project.DeveloperId - Developer.Id</summary>
		public virtual IEntityRelation DeveloperEntityUsingDeveloperId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Developer", false, new[] { DeveloperFields.Id, ProjectFields.DeveloperId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProjectRelations
	{
		internal static readonly IEntityRelation ProjectDiscussionEntityUsingProjectIdStatic = new ProjectRelations().ProjectDiscussionEntityUsingProjectId;
		internal static readonly IEntityRelation ProjectSubCategoryTableEntityUsingProjectIdStatic = new ProjectRelations().ProjectSubCategoryTableEntityUsingProjectId;
		internal static readonly IEntityRelation CategoryEntityUsingCategoryIdStatic = new ProjectRelations().CategoryEntityUsingCategoryId;
		internal static readonly IEntityRelation DeveloperEntityUsingDeveloperIdStatic = new ProjectRelations().DeveloperEntityUsingDeveloperId;

		/// <summary>CTor</summary>
		static StaticProjectRelations() { }
	}
}
