//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.9.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "playerContentController"
	/// <summary>Player Content Controller</summary>
	public partial interface IPlayerContentController : IPublishedContent
	{
		/// <summary>Player Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		global::Umbraco.Core.Models.PublishedContent.IPublishedContent PlayerImage { get; }

		/// <summary>Player Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		string PlayerName { get; }

		/// <summary>Player Points</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		int PlayerPoints { get; }

		/// <summary>Player Position</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		string PlayerPosition { get; }
	}

	/// <summary>Player Content Controller</summary>
	[PublishedModel("playerContentController")]
	public partial class PlayerContentController : PublishedContentModel, IPlayerContentController
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		public new const string ModelTypeAlias = "playerContentController";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PlayerContentController, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public PlayerContentController(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Player Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		[ImplementPropertyType("playerImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent PlayerImage => GetPlayerImage(this);

		/// <summary>Static getter for Player Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		public static global::Umbraco.Core.Models.PublishedContent.IPublishedContent GetPlayerImage(IPlayerContentController that) => that.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("playerImage");

		///<summary>
		/// Player Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		[ImplementPropertyType("playerName")]
		public string PlayerName => GetPlayerName(this);

		/// <summary>Static getter for Player Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		public static string GetPlayerName(IPlayerContentController that) => that.Value<string>("playerName");

		///<summary>
		/// Player Points
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		[ImplementPropertyType("playerPoints")]
		public int PlayerPoints => GetPlayerPoints(this);

		/// <summary>Static getter for Player Points</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		public static int GetPlayerPoints(IPlayerContentController that) => that.Value<int>("playerPoints");

		///<summary>
		/// Player Position
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		[ImplementPropertyType("playerPosition")]
		public string PlayerPosition => GetPlayerPosition(this);

		/// <summary>Static getter for Player Position</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.0")]
		public static string GetPlayerPosition(IPlayerContentController that) => that.Value<string>("playerPosition");
	}
}
