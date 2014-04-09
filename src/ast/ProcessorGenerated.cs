// ---------------------------------------------------------------------
// Base Processor class, auto-generated									
// 	Do NOT edit this file												
// 	Additional methods should be defined in another file				
// ---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using crosspascal.ast.nodes;

namespace crosspascal.ast
{
	public abstract partial class Processor<T>
	{
		//	Complete interface to be implemented by any specific AST processor	

		
		public virtual T Visit(FixmeNode node)
		{
			return Visit((Node) node);
		}
		
		public virtual T Visit(NotSupportedNode node)
		{
			return Visit((Node)node);
		}
		
		public virtual T Visit(EmptyNode node)
		{
			return Visit((Node)node);
		}
				
		public virtual T Visit(NodeList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(StatementList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(TypeList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(DeclarationList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(EnumValueList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(TranslationUnit node)
		{
			return Visit((Declaration)node);
		}
		
		public virtual T Visit(ProgramNode node)
		{
			Visit((TranslationUnit) node);
			return traverse(node.section);
		}
		
		public virtual T Visit(LibraryNode node)
		{
			Visit((TranslationUnit) node);
			return traverse(node.section);
		}

		public virtual T Visit(ProgramSection node)
		{
			Visit((TopLevelDeclarationSection)node);
			return traverse(node.block);
		}
		
		public virtual T Visit(UnitNode node)
		{
			Visit((TranslationUnit) node);
			traverse(node.@interface);
			traverse(node.implementation);
			traverse(node.initialization);
			traverse(node.finalization);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(PackageNode node)
		{
			Visit((TranslationUnit) node);
			traverse(node.requires);
			traverse(node.contains);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(UnitItem node)
		{
			return Visit((Node)node);
		}
		
		public virtual T Visit(UsesItem node)
		{
			return Visit((UnitItem)node);
		}
		
		public virtual T Visit(RequiresItem node)
		{
			return Visit((UnitItem)node);
		}
		
		public virtual T Visit(ContainsItem node)
		{
			return Visit((UnitItem)node);
		}
		
		public virtual T Visit(ExportItem node)
		{
			Visit((UnitItem) node);
			return traverse(node.formalparams);
		}
		
		public virtual T Visit(Section node)
		{
			Visit((Node) node);
			return traverse(node.decls);
		}
		
		public virtual T Visit(RoutineSection node)
		{
			Visit((Section) node);
			return traverse(node.block);
		}
		
		public virtual T Visit(ParametersSection node)
		{
			Visit((Section) node);
			return traverse(node.returnVar);
		}
				
		public virtual T Visit(TopLevelDeclarationSection node)
		{
			traverse(node.uses);
			return Visit((Section)node);
		}
		
		public virtual T Visit(InterfaceSection node)
		{
			return Visit((TopLevelDeclarationSection)node);
		}
		
		public virtual T Visit(ImplementationSection node)
		{
			return Visit((TopLevelDeclarationSection)node);
		}
		
		public virtual T Visit(Declaration node)
		{
			Visit((Node) node);
			return traverse(node.type);
		}
		
		public virtual T Visit(LabelDeclaration node)
		{
			return Visit((Declaration)node);
		}
		
		public virtual T Visit(ValueDeclaration node)
		{
			return Visit((Declaration)node);
		}
		
		public virtual T Visit(VarDeclaration node)
		{
			Visit((ValueDeclaration) node);
			return traverse(node.init);
		}
		
		public virtual T Visit(ParamDeclaration node)
		{
			Visit((ValueDeclaration) node);
			return traverse(node.init);
		}
		
		public virtual T Visit(VarParamDeclaration node)
		{
			return Visit((ParamDeclaration)node);
		}
		
		public virtual T Visit(ConstParamDeclaration node)
		{
			return Visit((ParamDeclaration)node);
		}
		
		public virtual T Visit(OutParamDeclaration node)
		{
			return Visit((ParamDeclaration)node);
		}
		
		public virtual T Visit(ConstDeclaration node)
		{
			Visit((ValueDeclaration) node);
			return traverse(node.init);
		}
		
		public virtual T Visit(EnumValue node)
		{
			return Visit((ConstDeclaration)node);
		}
		
		public virtual T Visit(TypeDeclaration node)
		{
			return Visit((Declaration)node);
		}
		
		public virtual T Visit(ProceduralType node)
		{
			Visit((TypeNode) node);
			traverse(node.@params);
			traverse(node.Directives);
			return traverse(node.funcret);
		}
		
		public virtual T Visit(MethodType node)
		{
			return Visit((ProceduralType)node);
		}
		
		public virtual T Visit(CallableDeclaration node)
		{
			Visit((Declaration) node);
			traverse(node.Directives);
			return traverse(node.Type);
		}
		
		public virtual T Visit(RoutineDeclaration node)
		{
			return Visit((CallableDeclaration)node);
		}
		
		public virtual T Visit(MethodDeclaration node)
		{
			return Visit((CallableDeclaration)node);
		}
		
		public virtual T Visit(RoutineDefinition node)
		{
			Visit((RoutineDeclaration)node);
			return traverse(node.body); 
		}
		
		public virtual T Visit(MethodDefinition node)
		{
			Visit((MethodDeclaration)node);
			return traverse(node.body);
		}
		
		public virtual T Visit(RoutineDirectives node)
		{
			return Visit((Node)node);
		}
		
		public virtual T Visit(ImportDirectives node)
		{
			return Visit((RoutineDirectives)node);
		}
		
		public virtual T Visit(MethodDirectives node)
		{
			return Visit((RoutineDirectives)node);
		}
		
		public virtual T Visit(CompositeDeclaration node)
		{
			Visit((TypeDeclaration) node);
			return traverse(node.Type);
		}
		
		public virtual T Visit(ClassDeclaration node)
		{
			return Visit((CompositeDeclaration)node);
		}
		
		public virtual T Visit(InterfaceDeclaration node)
		{
			return Visit((CompositeDeclaration)node);
		}
		
		public virtual T Visit(CompositeType node)
		{
			Visit((TypeNode) node);
			return traverse(node.section);
		}
		
		public virtual T Visit(ClassType node)
		{
			Visit((CompositeType) node);
			return traverse(node.self);
		}
		
		public virtual T Visit(InterfaceType node)
		{
			Visit((CompositeType) node);
			return traverse(node.guid);
		}
		
		public virtual T Visit(ClassRefType node)
		{
		//	Do not traverse this node! circular dependency
		//	traverse(node.reftype);
			return DefaultReturnValue();
		}

		public virtual T Visit(RecordRefType node)
		{
			//	Do not traverse this node! circular dependency
			//	traverse(node.reftype);
			return DefaultReturnValue();
		}

		public virtual T Visit(ObjectSection node)
		{
			Visit((Section) node);
			return traverse(node.fields);
		}
		
		public virtual T Visit(FieldDeclaration node)
		{
			return Visit((ValueDeclaration)node);
		}

		public virtual T Visit(RecordFieldDeclaration node)
		{
			return Visit((ValueDeclaration)node);
		}
		
		public virtual T Visit(VariantDeclaration node)
		{
			Visit((RecordFieldDeclaration) node);
			return traverse(node.varfields);
		}
		
		public virtual T Visit(VarEntryDeclaration node)
		{
			Visit((RecordFieldDeclaration) node);
			traverse(node.tagvalue);
			return traverse(node.fields);
		}
		
		public virtual T Visit(PropertyDeclaration node)
		{
			Visit((FieldDeclaration) node);
			return traverse(node.specifiers);
		}
		
		public virtual T Visit(ArrayProperty node)
		{
			Visit((PropertyDeclaration) node);
			return traverse(node.indexes);
		}
		
		public virtual T Visit(PropertySpecifiers node)
		{
			Visit((Node) node);
			traverse(node.index);
			traverse(node.stored);
			traverse(node.@default);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(Statement node)
		{
			return Visit((Node)node);
		}
		
		public virtual T Visit(LabelStatement node)
		{
			Visit((Statement) node);
			return traverse(node.stmt);
		}
		
		public virtual T Visit(EmptyStatement node)
		{
			return Visit((Statement)node);
		}
		
		public virtual T Visit(BreakStatement node)
		{
			return Visit((Statement)node);
		}
		
		public virtual T Visit(ContinueStatement node)
		{
			return Visit((Statement)node);
		}
		
		public virtual T Visit(Assignment node)
		{
			return Visit((Statement)node);
			traverse(node.lvalue);
			return traverse(node.expr);
		}
		
		public virtual T Visit(GotoStatement node)
		{
			return Visit((Statement)node);
		}
		
		public virtual T Visit(IfStatement node)
		{
			Visit((Statement) node);
			traverse(node.condition);
			traverse(node.thenblock);
			traverse(node.elseblock);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(ExpressionStatement node)
		{
			Visit((Statement) node);
			return traverse(node.expr);
		}
		
		public virtual T Visit(CaseSelector node)
		{
			Visit((Statement) node);
			traverse(node.list);
			traverse(node.stmt);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(CaseStatement node)
		{
			Visit((Statement) node);
			traverse(node.condition);
			traverse(node.selectors);
			traverse(node.caseelse);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(LoopStatement node)
		{
			Visit((Statement) node);
			traverse(node.condition);
			traverse(node.block);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(RepeatLoop node)
		{
			return Visit((LoopStatement) node);
		}
		
		public virtual T Visit(WhileLoop node)
		{
			return Visit((LoopStatement)node);
		}
		
		public virtual T Visit(ForLoop node)
		{
			Visit((LoopStatement) node);
			traverse(node.var);
			traverse(node.start);
			traverse(node.end);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(BlockStatement node)
		{
			Visit((Statement) node);
			return traverse(node.stmts);
		}
		
		public virtual T Visit(WithStatement node)
		{
			Visit((Statement) node);
			traverse(node.with);
			return traverse(node.body);
		}
		
		public virtual T Visit(TryFinallyStatement node)
		{
			Visit((Statement) node);
			traverse(node.body);
			return traverse(node.final);
		}
		
		public virtual T Visit(TryExceptStatement node)
		{
			Visit((Statement) node);
			traverse(node.body);
			return traverse(node.final);
		}
		
		public virtual T Visit(ExceptionBlock node)
		{
			Visit((Statement) node);
			traverse(node.onList);
			return traverse(node.@default);
		}
		
		public virtual T Visit(RaiseStatement node)
		{
			Visit((Statement) node);
			traverse(node.lvalue);
			return traverse(node.expr);
		}
		
		public virtual T Visit(OnStatement node)
		{
			Visit((Statement) node);
			return traverse(node.body);
		}
		
		public virtual T Visit(AssemblerBlock node)
		{
			return Visit((BlockStatement)node);
		}
		
		public virtual T Visit(Expression node)
		{
			Visit((Node) node);
			traverse(node.Type);
			traverse(node.Value);
			traverse(node.ForcedType);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(EmptyExpression node)
		{
			return Visit((Expression)node);
		}
		
		public virtual T Visit(ExpressionList node)
		{
			foreach (Node n in node.nodes)
				traverse(n);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(ConstExpression node)
		{
			return Visit((Expression)node);
		}
		
		public virtual T Visit(StructuredConstant node)
		{
			Visit((ConstExpression) node);
			return traverse(node.exprlist);
		}
		
		public virtual T Visit(ArrayConst node)
		{
			return Visit((StructuredConstant)node);
		}
		
		public virtual T Visit(RecordConst node)
		{
			return Visit((StructuredConstant)node);
		}
		
		public virtual T Visit(FieldInitList node)
		{
			Visit((ExpressionList) node);
			foreach (Node n in node.nodes)
				traverse(n);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(FieldInit node)
		{
			Visit((ConstExpression) node);
			return traverse(node.expr);
		}
		
		public virtual T Visit(ConstIdentifier node)
		{
			return Visit((ConstExpression)node);
		}
		
		public virtual T Visit(Literal node)
		{
			return Visit((ConstExpression) node);
		}
		
		public virtual T Visit(OrdinalLiteral node)
		{
			return Visit((Literal) node);
		}
		
		public virtual T Visit(IntLiteral node)
		{
			return Visit((OrdinalLiteral) node);
		}
		
		public virtual T Visit(CharLiteral node)
		{
			return Visit((OrdinalLiteral) node);
		}
		
		public virtual T Visit(BoolLiteral node)
		{
			return Visit((OrdinalLiteral) node);
		}
		
		public virtual T Visit(StringLiteral node)
		{
			return Visit((Literal) node);
		}
		
		public virtual T Visit(RealLiteral node)
		{
			return Visit((Literal) node);
		}
		
		public virtual T Visit(PointerLiteral node)
		{
			return Visit((Literal) node);
		}
		
		public virtual T Visit(ConstantValue node)
		{
			return Visit((Node) node);
		}
		
		public virtual T Visit(IntegralValue node)
		{
			return Visit((ConstantValue) node);
		}
		
		public virtual T Visit(StringValue node)
		{
			return Visit((ConstantValue) node);
		}
		
		public virtual T Visit(RealValue node)
		{
			return Visit((ConstantValue) node);
		}
		
		public virtual T Visit(BinaryExpression node)
		{
			return Visit((Expression) node);
		}
		
		public virtual T Visit(SetIn node)
		{
			Visit((BinaryExpression) node);
			traverse(node.expr);
			traverse(node.set);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(SetRange node)
		{
			return Visit((BinaryExpression) node);
		}
		
		public virtual T Visit(ArithmethicBinaryExpression node)
		{
			Visit((BinaryExpression) node);
			traverse(node.left);
			traverse(node.right);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(Subtraction node)
		{
			return Visit((ArithmethicBinaryExpression) node);
		}
		
		public virtual T Visit(Addition node)
		{
			return Visit((ArithmethicBinaryExpression) node);
		}
		
		public virtual T Visit(Product node)
		{
			return Visit((ArithmethicBinaryExpression) node);
		}
		
		public virtual T Visit(Division node)
		{
			return Visit((ArithmethicBinaryExpression) node);
		}
		
		public virtual T Visit(Quotient node)
		{
			return Visit((ArithmethicBinaryExpression) node);
		}
		
		public virtual T Visit(Modulus node)
		{
			return Visit((ArithmethicBinaryExpression) node);
		}
		
		public virtual T Visit(ShiftRight node)
		{
			return Visit((ArithmethicBinaryExpression) node);
		}
		
		public virtual T Visit(ShiftLeft node)
		{
			return Visit((ArithmethicBinaryExpression) node);
		}
		
		public virtual T Visit(LogicalBinaryExpression node)
		{
			Visit((BinaryExpression) node);
			traverse(node.left);
			traverse(node.right);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(LogicalAnd node)
		{
			return Visit((LogicalBinaryExpression) node);
		}
		
		public virtual T Visit(LogicalOr node)
		{
			return Visit((LogicalBinaryExpression) node);
		}
		
		public virtual T Visit(LogicalXor node)
		{
			return Visit((LogicalBinaryExpression) node);
		}
		
		public virtual T Visit(Equal node)
		{
			return Visit((LogicalBinaryExpression) node);
		}
		
		public virtual T Visit(NotEqual node)
		{
			return Visit((LogicalBinaryExpression) node);
		}
		
		public virtual T Visit(LessThan node)
		{
			return Visit((LogicalBinaryExpression) node);
		}
		
		public virtual T Visit(LessOrEqual node)
		{
			return Visit((LogicalBinaryExpression) node);
		}
		
		public virtual T Visit(GreaterThan node)
		{
			return Visit((LogicalBinaryExpression) node);
		}
		
		public virtual T Visit(GreaterOrEqual node)
		{
			return Visit((LogicalBinaryExpression) node);
		}
		
		public virtual T Visit(TypeBinaryExpression node)
		{
			Visit((BinaryExpression) node);
			traverse(node.expr);
			traverse(node.types);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(TypeIs node)
		{
			return Visit((TypeBinaryExpression) node);
		}
		
		public virtual T Visit(RuntimeCast node)
		{
			return Visit((TypeBinaryExpression) node);
		}
		
		public virtual T Visit(UnaryExpression node)
		{
			return Visit((Expression) node);
		}
		
		public virtual T Visit(SimpleUnaryExpression node)
		{
			Visit((Expression) node);
			return traverse(node.expr);
		}
		
		public virtual T Visit(UnaryPlus node)
		{
			return Visit((SimpleUnaryExpression) node);
		}
		
		public virtual T Visit(UnaryMinus node)
		{
			return Visit((SimpleUnaryExpression) node);
		}
		
		public virtual T Visit(LogicalNot node)
		{
			return Visit((SimpleUnaryExpression) node);
		}
		
		public virtual T Visit(AddressLvalue node)
		{
			return Visit((SimpleUnaryExpression) node);
		}
		
		public virtual T Visit(Set node)
		{
			Visit((UnaryExpression) node);
			return traverse(node.setelems);
		}

		public virtual T Visit(LvalueAsExpr node)
		{
			Visit((UnaryExpression) node);
			return traverse(node.lval);
		}

		public virtual T Visit(LvalueExpression node)
		{
			return Visit((UnaryExpression) node);
		}
		
		public virtual T Visit(ExprAsLvalue node)
		{
			Visit((LvalueExpression) node);
			return traverse(node.expr);
		}
		
		public virtual T Visit(StaticCast node)
		{
			Visit((LvalueExpression) node);
			traverse(node.casttype);
			return traverse(node.expr);
		}
		
		public virtual T Visit(UnresolvedId node)
		{
			Visit((LvalueExpression) node);
			return traverse(node.id);
		}
		
		public virtual T Visit(UnresolvedCall node)
		{
			Visit((LvalueExpression) node);
			traverse(node.func);
			traverse(node.args);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(ArrayAccess node)
		{
			Visit((LvalueExpression) node);
			traverse(node.lvalue);
			traverse(node.acessors);
			traverse(node.array);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(PointerDereference node)
		{
			Visit((LvalueExpression) node);
			return traverse(node.expr);
		}
		
		public virtual T Visit(InheritedCall node)
		{
			return Visit((RoutineCall)node);
		}
		
		public virtual T Visit(RoutineCall node)
		{
			Visit((LvalueExpression) node);
			T t = traverse(node.func);
			traverse(node.args);
			return t;
		}
		
		public virtual T Visit(ObjectAccess node)
		{
			Visit((LvalueExpression) node);
			return traverse(node.obj);
		}
		
		public virtual T Visit(Identifier node)
		{
			return Visit((LvalueExpression) node);
		}

		public virtual T Visit(IdentifierStatic node)
		{
			return Visit((LvalueExpression)node);
		}

		public virtual T Visit(TypeNode node)
		{
			return Visit((Node) node);
		}
		
		public virtual T Visit(UnresolvedType node)
		{
			return Visit((TypeNode) node);
		}
		
		public virtual T Visit(UnresolvedVariableType node)
		{
			return Visit((VariableType) node);
		}
		
		public virtual T Visit(UnresolvedIntegralType node)
		{
			return Visit((IntegralType) node);
		}
		
		public virtual T Visit(UnresolvedOrdinalType node)
		{
			return Visit((VariableType) node);
		}
		
		public virtual T Visit(VariableType node)
		{
			return Visit((TypeNode) node);
		}
		
		public virtual T Visit(MetaclassType node)
		{
			Visit((VariableType) node);
			return traverse(node.baseType);
		}
		
		public virtual T Visit(EnumType node)
		{
			Visit((VariableType) node);
			return traverse(node.enumVals);
		}
		
		public virtual T Visit(RangeType node)
		{
			Visit((VariableType) node);
			traverse(node.min);
			traverse(node.max);
			return DefaultReturnValue();
		}
		
		public virtual T Visit(ScalarType node)
		{
			return Visit((VariableType) node);
		}
		
		public virtual T Visit(IntegralType node)
		{
			return Visit((ScalarType) node);
		}
		
		public virtual T Visit(IntegerType node)
		{
			return Visit((IntegralType) node);
		}
		
		public virtual T Visit(SignedIntegerType node)
		{
			return Visit((IntegerType) node);
		}
		
		public virtual T Visit(UnsignedIntegerType node)
		{
			return Visit((IntegerType) node);
		}
		
		public virtual T Visit(UnsignedInt8Type node)
		{
			return Visit((UnsignedIntegerType) node);
		}
		
		public virtual T Visit(UnsignedInt16Type node)
		{
			return Visit((UnsignedIntegerType) node);
		}
		
		public virtual T Visit(UnsignedInt32Type node)
		{
			return Visit((UnsignedIntegerType) node);
		}
		
		public virtual T Visit(UnsignedInt64Type node)
		{
			return Visit((UnsignedIntegerType) node);
		}
		
		public virtual T Visit(SignedInt8Type node)
		{
			return Visit((SignedIntegerType) node);
		}
		
		public virtual T Visit(SignedInt16Type node)
		{
			return Visit((SignedIntegerType) node);
		}
		
		public virtual T Visit(SignedInt32Type node)
		{
			return Visit((SignedIntegerType) node);
		}
		
		public virtual T Visit(SignedInt64Type node)
		{
			return Visit((IntegerType) node);
		}
		
		public virtual T Visit(BoolType node)
		{
			return Visit((IntegralType) node);
		}
		
		public virtual T Visit(CharType node)
		{
			return Visit((IntegralType) node);
		}
		
		public virtual T Visit(RealType node)
		{
			return Visit((ScalarType) node);
		}
		
		public virtual T Visit(FloatType node)
		{
			return Visit((RealType) node);
		}
		
		public virtual T Visit(DoubleType node)
		{
			return Visit((RealType) node);
		}
		
		public virtual T Visit(ExtendedType node)
		{
			return Visit((RealType) node);
		}
		
		public virtual T Visit(CurrencyType node)
		{
			return Visit((RealType) node);
		}
		
		public virtual T Visit(StringType node)
		{
			return Visit((ScalarType) node);
		}
		
		public virtual T Visit(FixedStringType node)
		{
			Visit((StringType) node);
			return traverse(node.expr);
		}
		
		public virtual T Visit(VariantType node)
		{
			Visit((VariableType) node);
			return traverse(node.actualtype);
		}
		
		public virtual T Visit(PointerType node)
		{
			Visit((ScalarType) node);
			return traverse(node.pointedType);
		}
		
		public virtual T Visit(StructuredType node)
		{
			Visit((VariableType) node);
			return traverse(node.basetype);
		}
		
		public virtual T Visit(ArrayType node)
		{
			return Visit((StructuredType) node);
		}
		
		public virtual T Visit(SetType node)
		{
			return Visit((StructuredType) node);
		}
		
		public virtual T Visit(FileType node)
		{
			return Visit((StructuredType) node);
		}
		
		public virtual T Visit(RecordType node)
		{
			Visit((StructuredType) node);
			return traverse(node.compTypes);
		}
	}
}
