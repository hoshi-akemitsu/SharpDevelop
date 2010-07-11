﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Siegfried Pammer" email="siegfriedpammer@gmail.com" />
//     <version>$Revision$</version>
// </file>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICSharpCode.NRefactory.Parser.VB
{
	public class ExpressionFinderState
	{
		public bool WasQualifierTokenAtStart { get; set; }
		public bool NextTokenIsPotentialStartOfExpression { get; set; }
		public bool ReadXmlIdentifier { get; set; }
		public bool NextTokenIsStartOfImportsOrAccessExpression { get; set; }
		public Stack<int> StateStack { get; set; }
		public Stack<Block> BlockStack { get; set; }
		public int CurrentState { get; set; }
	}
}
