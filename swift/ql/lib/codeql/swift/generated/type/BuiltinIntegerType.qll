// generated by codegen/codegen.py
import codeql.swift.elements.type.AnyBuiltinIntegerType

class BuiltinIntegerTypeBase extends @builtin_integer_type, AnyBuiltinIntegerType {
  override string getAPrimaryQlClass() { result = "BuiltinIntegerType" }
}