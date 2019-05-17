﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.4.</auto-generated>
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
using AqarPress.Data.HelperClasses;
using AqarPress.Data.FactoryClasses;
using AqarPress.Data.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AqarPress.Data.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'ProjectDiscussion'.<br/><br/></summary>
	[Serializable]
	public partial class ProjectDiscussionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private ProjectEntity _project;
		private UserEntity _user;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ProjectDiscussionEntityStaticMetaData _staticMetaData = new ProjectDiscussionEntityStaticMetaData();
		private static ProjectDiscussionRelations _relationsFactory = new ProjectDiscussionRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Project</summary>
			public static readonly string Project = "Project";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProjectDiscussionEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProjectDiscussionEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProjectDiscussionEntity", InheritanceHierarchyType.None, false, (int)AqarPress.Data.EntityType.ProjectDiscussionEntity, typeof(ProjectDiscussionEntity), typeof(ProjectDiscussionEntityFactory), false);
				AddNavigatorMetaData<ProjectDiscussionEntity, ProjectEntity>("Project", "ProjectDiscussions", (a, b) => a._project = b, a => a._project, (a, b) => a.Project = b, AqarPress.Data.RelationClasses.StaticProjectDiscussionRelations.ProjectEntityUsingProjectIdStatic, ()=>new ProjectDiscussionRelations().ProjectEntityUsingProjectId, null, new int[] { (int)ProjectDiscussionFieldIndex.ProjectId }, null, true, (int)AqarPress.Data.EntityType.ProjectEntity);
				AddNavigatorMetaData<ProjectDiscussionEntity, UserEntity>("User", "ProjectDiscussions", (a, b) => a._user = b, a => a._user, (a, b) => a.User = b, AqarPress.Data.RelationClasses.StaticProjectDiscussionRelations.UserEntityUsingCommenterIdStatic, ()=>new ProjectDiscussionRelations().UserEntityUsingCommenterId, null, new int[] { (int)ProjectDiscussionFieldIndex.CommenterId }, null, true, (int)AqarPress.Data.EntityType.UserEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProjectDiscussionEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProjectDiscussionEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProjectDiscussionEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProjectDiscussionEntity</param>
		public ProjectDiscussionEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for ProjectDiscussion which data should be fetched into this ProjectDiscussion object</param>
		public ProjectDiscussionEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for ProjectDiscussion which data should be fetched into this ProjectDiscussion object</param>
		/// <param name="validator">The custom validator object for this ProjectDiscussionEntity</param>
		public ProjectDiscussionEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProjectDiscussionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Project' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProject() { return CreateRelationInfoForNavigator("Project"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'User' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUser() { return CreateRelationInfoForNavigator("User"); }
		
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
		/// <param name="validator">The validator object for this ProjectDiscussionEntity</param>
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
		public static ProjectDiscussionRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Project' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProject { get { return _staticMetaData.GetPrefetchPathElement("Project", CommonEntityBase.CreateEntityCollection<ProjectEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUser { get { return _staticMetaData.GetPrefetchPathElement("User", CommonEntityBase.CreateEntityCollection<UserEntity>()); } }

		/// <summary>The CommenterId property of the Entity ProjectDiscussion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProjectDiscussion"."commenter_id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CommenterId
		{
			get { return (System.Int32)GetValue((int)ProjectDiscussionFieldIndex.CommenterId, true); }
			set	{ SetValue((int)ProjectDiscussionFieldIndex.CommenterId, value); }
		}

		/// <summary>The DateCreated property of the Entity ProjectDiscussion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProjectDiscussion"."date_created".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DateCreated
		{
			get { return (System.DateTime)GetValue((int)ProjectDiscussionFieldIndex.DateCreated, true); }
			set	{ SetValue((int)ProjectDiscussionFieldIndex.DateCreated, value); }
		}

		/// <summary>The Id property of the Entity ProjectDiscussion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProjectDiscussion"."id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)ProjectDiscussionFieldIndex.Id, true); }
			set { SetValue((int)ProjectDiscussionFieldIndex.Id, value); }		}

		/// <summary>The MessageBody property of the Entity ProjectDiscussion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProjectDiscussion"."message_body".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String MessageBody
		{
			get { return (System.String)GetValue((int)ProjectDiscussionFieldIndex.MessageBody, true); }
			set	{ SetValue((int)ProjectDiscussionFieldIndex.MessageBody, value); }
		}

		/// <summary>The ProjectId property of the Entity ProjectDiscussion<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProjectDiscussion"."project_id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProjectId
		{
			get { return (System.Int32)GetValue((int)ProjectDiscussionFieldIndex.ProjectId, true); }
			set	{ SetValue((int)ProjectDiscussionFieldIndex.ProjectId, value); }
		}

		/// <summary>Gets / sets related entity of type 'ProjectEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProjectEntity Project
		{
			get { return _project; }
			set { SetSingleRelatedEntityNavigator(value, "Project"); }
		}

		/// <summary>Gets / sets related entity of type 'UserEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UserEntity User
		{
			get { return _user; }
			set { SetSingleRelatedEntityNavigator(value, "User"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AqarPress.Data
{
	public enum ProjectDiscussionFieldIndex
	{
		///<summary>CommenterId. </summary>
		CommenterId,
		///<summary>DateCreated. </summary>
		DateCreated,
		///<summary>Id. </summary>
		Id,
		///<summary>MessageBody. </summary>
		MessageBody,
		///<summary>ProjectId. </summary>
		ProjectId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AqarPress.Data.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProjectDiscussion. </summary>
	public partial class ProjectDiscussionRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between ProjectDiscussionEntity and ProjectEntity over the m:1 relation they have, using the relation between the fields: ProjectDiscussion.ProjectId - Project.Id</summary>
		public virtual IEntityRelation ProjectEntityUsingProjectId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Project", false, new[] { ProjectFields.Id, ProjectDiscussionFields.ProjectId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProjectDiscussionEntity and UserEntity over the m:1 relation they have, using the relation between the fields: ProjectDiscussion.CommenterId - User.Id</summary>
		public virtual IEntityRelation UserEntityUsingCommenterId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "User", false, new[] { UserFields.Id, ProjectDiscussionFields.CommenterId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProjectDiscussionRelations
	{
		internal static readonly IEntityRelation ProjectEntityUsingProjectIdStatic = new ProjectDiscussionRelations().ProjectEntityUsingProjectId;
		internal static readonly IEntityRelation UserEntityUsingCommenterIdStatic = new ProjectDiscussionRelations().UserEntityUsingCommenterId;

		/// <summary>CTor</summary>
		static StaticProjectDiscussionRelations() { }
	}
}