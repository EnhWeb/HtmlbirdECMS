// ===============================================================================
//  产品名称：网鸟电子商务管理系统(Htmlbird ECMS)
//  产品作者：YMind Chan
//  版权所有：网鸟IT技术论坛 颜铭工作室
// ===============================================================================
//  Copyright © Htmlbird.Net. All rights reserved .
//  官方网站：http://www.htmlbird.net/
//  技术论坛：http://bbs.htmlbird.net/
// ===============================================================================
namespace Net.Htmlbird.Framework.Web.Paging
{
	/// <summary>
	/// 包含翻页链接构造器的外观封装。
	/// </summary>
	public static class PageLink
	{
		/// <summary>
		/// 创建 <see cref="PageLinkPane"/> 类的新实例。
		/// </summary>
		/// <param name="url">包含翻页链接按钮所关联的链接的字符串。此字符串必须包含“[#PageIndex#]”并用其来描述翻页索引数字。</param>
		/// <param name="paginationArgs">包含构造翻页链接需要的参数的 <see cref="PaginationArgs"/>。</param>
		public static PageLinkPane CreatePageLinkPane(string url, PaginationArgs paginationArgs) { return new PageLinkPane(url, paginationArgs); }
	}
}