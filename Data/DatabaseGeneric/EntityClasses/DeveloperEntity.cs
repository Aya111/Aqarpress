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
	/// <summary>Entity class which represents the entity 'Developer'.<br/><br/></summary>
	[Serializable]
	public partial class DeveloperEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<ProjectEntity> _projects;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static DeveloperEntityStaticMetaData _staticMetaData = new DeveloperEntityStaticMetaData();
		private static DeveloperRelations _relationsFactory = new DeveloperRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Projects</summary>
			public static readonly string Projects = "Projects";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class DeveloperEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public DeveloperEntityStaticMetaData()
			{
				SetEntityCoreInfo("DeveloperEntity", InheritanceHierarchyType.None, false, (int)DB_A4D6F8_AqarPress.Data.EntityType.DeveloperEntity, typeof(DeveloperEntity), typeof(DeveloperEntityFactory), false);
				AddNavigatorMetaData<DeveloperEntity, EntityCollection<ProjectEntity>>("Projects", a => a._projects, (a, b) => a._projects = b, a => a.Projects, () => new DeveloperRelations().ProjectEntityUsingDeveloperId, typeof(ProjectEntity), (int)DB_A4D6F8_AqarPress.Data.EntityType.ProjectEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static DeveloperEntity()
		{
		}

		/// <summary> CTor</summary>
		public DeveloperEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DeveloperEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DeveloperEntity</param>
		public DeveloperEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Developer which data should be fetched into this Developer object</param>
		public DeveloperEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Developer which data should be fetched into this Developer object</param>
		/// <param name="validator">The custom validator object for this DeveloperEntity</param>
		public DeveloperEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DeveloperEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Project' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProjects() { return CreateRelationInfoForNavigator("Projects"); }
		
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
		/// <param name="validator">The validator object for this DeveloperEntity</param>
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
		public static DeveloperRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Project' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProjects { get { return _staticMetaData.GetPrefetchPathElement("Projects", CommonEntityBase.CreateEntityCollection<ProjectEntity>()); } }

		/// <summary>The ArabicName property of the Entity Developer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Developer"."arabic_name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ArabicName
		{
			get { return (System.String)GetValue((int)DeveloperFieldIndex.ArabicName, true); }
			set	{ SetValue((int)DeveloperFieldIndex.ArabicName, value); }
		}

		/// <summary>The Id property of the Entity Developer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Developer"."id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)DeveloperFieldIndex.Id, true); }
			set { SetValue((int)DeveloperFieldIndex.Id, value); }		}

		/// <summary>The IsActive property of the Entity Developer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Developer"."is_active".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)DeveloperFieldIndex.IsActive, true); }
			set	{ SetValue((int)DeveloperFieldIndex.IsActive, value); }
		}

		/// <summary>The Name property of the Entity Developer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Developer"."name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)DeveloperFieldIndex.Name, true); }
			set	{ SetValue((int)DeveloperFieldIndex.Name, value); }
		}

		/// <summary>The Path property of the Entity Developer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Developer"."path".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Path
		{
			get { return (System.String)GetValue((int)DeveloperFieldIndex.Path, true); }
			set	{ SetValue((int)DeveloperFieldIndex.Path, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'ProjectEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProjectEntity))]
		public virtual EntityCollection<ProjectEntity> Projects { get { return GetOrCreateEntityCollection<ProjectEntity, ProjectEntityFactory>("Developer", true, false, ref _projects); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace DB_A4D6F8_AqarPress.Data
{
	public enum DeveloperFieldIndex
	{
		///<summary>ArabicName. </summary>
		ArabicName,
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
	/// <summary>Implements the relations factory for the entity: Developer. </summary>
	public partial class DeveloperRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between DeveloperEntity and ProjectEntity over the 1:n relation they have, using the relation between the fields: Developer.Id - Project.DeveloperId</summary>
		public virtual IEntityRelation ProjectEntityUsingDeveloperId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Projects", true, new[] { DeveloperFields.Id, ProjectFields.DeveloperId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticDeveloperRelations
	{
		internal static readonly IEntityRelation ProjectEntityUsingDeveloperIdStatic = new DeveloperRelations().ProjectEntityUsingDeveloperId;

		/// <summary>CTor</summary>
		static StaticDeveloperRelations() { }
	}
}
