﻿// ===============================================================================
//  产品名称：网鸟电子商务管理系统(Htmlbird ECMS)
//  产品作者：YMind Chan
//  版权所有：网鸟IT技术论坛 颜铭工作室
// ===============================================================================
//  Copyright © Htmlbird.Net. All rights reserved .
//  官方网站：http://www.htmlbird.net/
//  技术论坛：http://bbs.htmlbird.net/
// ===============================================================================
namespace Net.Htmlbird.Framework.Web
{
	/// <summary>
	/// 表示图形补白，包含了图形补白的尺寸。
	/// </summary>
	public struct ImagePadding
	{
		#region 私有字段

		private int _bottom;
		private int _left;
		private int _right;
		private int _top;

		#endregion

		#region 构造函数

		/// <summary>
		/// 初始化图形补白的新实例。
		/// </summary>
		/// <param name="all">指定补白大小。</param>
		public ImagePadding(int all) : this(all, all, all, all) { }

		/// <summary>
		/// 初始化图形补白的新实例。
		/// </summary>
		/// <param name="lar">指定左右两侧的补白大小。</param>
		/// <param name="tab">指定上下两侧的补白大小。</param>
		public ImagePadding(int lar, int tab) : this(lar, tab, lar, tab) { }

		/// <summary>
		/// 初始化图形补白的新实例。
		/// </summary>
		/// <param name="left">指定左补白的大小。</param>
		/// <param name="top">指定上补白的大小。</param>
		/// <param name="right">指定右补白的大小。</param>
		/// <param name="bottom">指定下补白的大小。</param>
		public ImagePadding(int left, int top, int right, int bottom)
		{
			this._left = left;
			this._top = top;
			this._right = right;
			this._bottom = bottom;
		}

		#endregion

		#region IImageWidth 成员

		/// <summary>
		/// 获取或设置左补白的大小。
		/// </summary>
		public int Left
		{
			get
			{
				if (this._left <= 0) this._left = 0;

				return this._left;
			}
			set { this._left = value; }
		}

		/// <summary>
		/// 获取或设置上补白的大小。
		/// </summary>
		public int Top
		{
			get
			{
				if (this._top <= 0) this._top = 0;

				return this._top;
			}
			set { this._top = value; }
		}

		/// <summary>
		/// 获取或设置右补白的大小。
		/// </summary>
		public int Right
		{
			get
			{
				if (this._right <= 0) this._right = 0;

				return this._right;
			}
			set { this._right = value; }
		}

		/// <summary>
		/// 获取或设置下补白的大小。
		/// </summary>
		public int Bottom
		{
			get
			{
				if (this._bottom <= 0) this._bottom = 0;

				return this._bottom;
			}
			set { this._bottom = value; }
		}

		#endregion
	}
}