// generated by codegen/codegen.py
import codeql.swift.elements.pattern.Pattern

class BindingPatternBase extends @binding_pattern, Pattern {
  override string getAPrimaryQlClass() { result = "BindingPattern" }

  Pattern getSubPattern() {
    exists(Pattern x |
      binding_patterns(this, x) and
      result = x.resolve()
    )
  }
}