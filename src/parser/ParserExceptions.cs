using System;
using System.Collections;
using System.IO;
using System.Text;

namespace crosspascal.parser
{	
	//thrown for irrecoverable syntax errors and stack overflow.

	public class ParserException : System.Exception
	{
		const string DefaultMsg = "Syntax Error";
	
		public ParserException (int lineno, string message = DefaultMsg)
				: base (message + " in line " + lineno) { }
		
		public ParserException (string message = DefaultMsg)
				: base (message) { }
	}

	public class UnexpectedEof : ParserException
	{
		const string DefaultMsg = "Encountered unexpected EOF";
	
		public UnexpectedEof (int lineno, string message = DefaultMsg) : base (lineno,message) { }
		
		public UnexpectedEof (string message = DefaultMsg) : base (message) { }
	}
	
	public class InputRejected : ParserException
	{
		const string DefaultMsg = "Input invalid - terminated by REJECT action";
	
		public InputRejected (int lineno, string message = DefaultMsg) : base (lineno,message) { }
		
		public InputRejected (string message = DefaultMsg) : base (message) { }
	}

	class ScannerException : ParserException 
	{
		internal ScannerException(int line, string msg = "Lexical Error")
			: base(msg + " in line " + line) { }
		
		internal ScannerException(string msg = "Lexical Error") : base(msg) { }
	}
	
	class PreprocessorException : ParserException 
	{
		internal PreprocessorException(int line, string msg = "Preprocessor Error")
			: base(msg + " in line " + line) { }

		internal PreprocessorException(string msg = "Preprocessor Error") : base(msg) { }
	}	
}