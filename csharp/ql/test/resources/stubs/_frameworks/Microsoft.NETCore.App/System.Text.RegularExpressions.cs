// This file contains auto-generated code.

namespace System
{
    namespace Text
    {
        namespace RegularExpressions
        {
            // Generated from `System.Text.RegularExpressions.Capture` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public class Capture
            {
                internal Capture() => throw null;
                public int Index { get => throw null; }
                public int Length { get => throw null; }
                public override string ToString() => throw null;
                public string Value { get => throw null; }
                public System.ReadOnlySpan<System.Char> ValueSpan { get => throw null; }
            }

            // Generated from `System.Text.RegularExpressions.CaptureCollection` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public class CaptureCollection : System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Capture>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
            {
                void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture item) => throw null;
                int System.Collections.IList.Add(object value) => throw null;
                void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() => throw null;
                void System.Collections.IList.Clear() => throw null;
                bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture item) => throw null;
                bool System.Collections.IList.Contains(object value) => throw null;
                public void CopyTo(System.Array array, int arrayIndex) => throw null;
                public void CopyTo(System.Text.RegularExpressions.Capture[] array, int arrayIndex) => throw null;
                public int Count { get => throw null; }
                public System.Collections.IEnumerator GetEnumerator() => throw null;
                System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() => throw null;
                int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture item) => throw null;
                int System.Collections.IList.IndexOf(object value) => throw null;
                void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, System.Text.RegularExpressions.Capture item) => throw null;
                void System.Collections.IList.Insert(int index, object value) => throw null;
                bool System.Collections.IList.IsFixedSize { get => throw null; }
                public bool IsReadOnly { get => throw null; }
                public bool IsSynchronized { get => throw null; }
                public System.Text.RegularExpressions.Capture this[int i] { get => throw null; }
                System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.this[int index] { get => throw null; set => throw null; }
                object System.Collections.IList.this[int index] { get => throw null; set => throw null; }
                bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture item) => throw null;
                void System.Collections.IList.Remove(object value) => throw null;
                void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index) => throw null;
                void System.Collections.IList.RemoveAt(int index) => throw null;
                public object SyncRoot { get => throw null; }
            }

            // Generated from `System.Text.RegularExpressions.Group` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public class Group : System.Text.RegularExpressions.Capture
            {
                public System.Text.RegularExpressions.CaptureCollection Captures { get => throw null; }
                internal Group() => throw null;
                public string Name { get => throw null; }
                public bool Success { get => throw null; }
                public static System.Text.RegularExpressions.Group Synchronized(System.Text.RegularExpressions.Group inner) => throw null;
            }

            // Generated from `System.Text.RegularExpressions.GroupCollection` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public class GroupCollection : System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Text.RegularExpressions.Group>>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>, System.Collections.Generic.IList<System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<string, System.Text.RegularExpressions.Group>>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyDictionary<string, System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Group>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
            {
                void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group item) => throw null;
                int System.Collections.IList.Add(object value) => throw null;
                void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() => throw null;
                void System.Collections.IList.Clear() => throw null;
                bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group item) => throw null;
                bool System.Collections.IList.Contains(object value) => throw null;
                public bool ContainsKey(string key) => throw null;
                public void CopyTo(System.Array array, int arrayIndex) => throw null;
                public void CopyTo(System.Text.RegularExpressions.Group[] array, int arrayIndex) => throw null;
                public int Count { get => throw null; }
                public System.Collections.IEnumerator GetEnumerator() => throw null;
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Text.RegularExpressions.Group>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Text.RegularExpressions.Group>>.GetEnumerator() => throw null;
                System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() => throw null;
                int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group item) => throw null;
                int System.Collections.IList.IndexOf(object value) => throw null;
                void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, System.Text.RegularExpressions.Group item) => throw null;
                void System.Collections.IList.Insert(int index, object value) => throw null;
                bool System.Collections.IList.IsFixedSize { get => throw null; }
                public bool IsReadOnly { get => throw null; }
                public bool IsSynchronized { get => throw null; }
                public System.Text.RegularExpressions.Group this[int groupnum] { get => throw null; }
                System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.this[int index] { get => throw null; set => throw null; }
                object System.Collections.IList.this[int index] { get => throw null; set => throw null; }
                public System.Text.RegularExpressions.Group this[string groupname] { get => throw null; }
                public System.Collections.Generic.IEnumerable<string> Keys { get => throw null; }
                bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group item) => throw null;
                void System.Collections.IList.Remove(object value) => throw null;
                void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) => throw null;
                void System.Collections.IList.RemoveAt(int index) => throw null;
                public object SyncRoot { get => throw null; }
                public bool TryGetValue(string key, out System.Text.RegularExpressions.Group value) => throw null;
                public System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group> Values { get => throw null; }
            }

            // Generated from `System.Text.RegularExpressions.Match` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public class Match : System.Text.RegularExpressions.Group
            {
                public static System.Text.RegularExpressions.Match Empty { get => throw null; }
                public virtual System.Text.RegularExpressions.GroupCollection Groups { get => throw null; }
                public System.Text.RegularExpressions.Match NextMatch() => throw null;
                public virtual string Result(string replacement) => throw null;
                public static System.Text.RegularExpressions.Match Synchronized(System.Text.RegularExpressions.Match inner) => throw null;
            }

            // Generated from `System.Text.RegularExpressions.MatchCollection` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public class MatchCollection : System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>, System.Collections.Generic.IList<System.Text.RegularExpressions.Match>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Match>, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Match>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
            {
                void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match item) => throw null;
                int System.Collections.IList.Add(object value) => throw null;
                void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() => throw null;
                void System.Collections.IList.Clear() => throw null;
                bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match item) => throw null;
                bool System.Collections.IList.Contains(object value) => throw null;
                public void CopyTo(System.Array array, int arrayIndex) => throw null;
                public void CopyTo(System.Text.RegularExpressions.Match[] array, int arrayIndex) => throw null;
                public int Count { get => throw null; }
                public System.Collections.IEnumerator GetEnumerator() => throw null;
                System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() => throw null;
                int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match item) => throw null;
                int System.Collections.IList.IndexOf(object value) => throw null;
                void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, System.Text.RegularExpressions.Match item) => throw null;
                void System.Collections.IList.Insert(int index, object value) => throw null;
                bool System.Collections.IList.IsFixedSize { get => throw null; }
                public bool IsReadOnly { get => throw null; }
                public bool IsSynchronized { get => throw null; }
                public virtual System.Text.RegularExpressions.Match this[int i] { get => throw null; }
                System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.this[int index] { get => throw null; set => throw null; }
                object System.Collections.IList.this[int index] { get => throw null; set => throw null; }
                bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match item) => throw null;
                void System.Collections.IList.Remove(object value) => throw null;
                void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) => throw null;
                void System.Collections.IList.RemoveAt(int index) => throw null;
                public object SyncRoot { get => throw null; }
            }

            // Generated from `System.Text.RegularExpressions.MatchEvaluator` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public delegate string MatchEvaluator(System.Text.RegularExpressions.Match match);

            // Generated from `System.Text.RegularExpressions.Regex` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public class Regex : System.Runtime.Serialization.ISerializable
            {
                public static int CacheSize { get => throw null; set => throw null; }
                protected System.Collections.IDictionary CapNames { get => throw null; set => throw null; }
                protected System.Collections.IDictionary Caps { get => throw null; set => throw null; }
                public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname) => throw null;
                public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname, System.Reflection.Emit.CustomAttributeBuilder[] attributes) => throw null;
                public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname, System.Reflection.Emit.CustomAttributeBuilder[] attributes, string resourceFile) => throw null;
                public static string Escape(string str) => throw null;
                public string[] GetGroupNames() => throw null;
                public int[] GetGroupNumbers() => throw null;
                void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) => throw null;
                public string GroupNameFromNumber(int i) => throw null;
                public int GroupNumberFromName(string name) => throw null;
                public static System.TimeSpan InfiniteMatchTimeout;
                protected void InitializeReferences() => throw null;
                public bool IsMatch(string input) => throw null;
                public bool IsMatch(string input, int startat) => throw null;
                public static bool IsMatch(string input, string pattern) => throw null;
                public static bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) => throw null;
                public static bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) => throw null;
                public System.Text.RegularExpressions.Match Match(string input) => throw null;
                public System.Text.RegularExpressions.Match Match(string input, int startat) => throw null;
                public System.Text.RegularExpressions.Match Match(string input, int beginning, int length) => throw null;
                public static System.Text.RegularExpressions.Match Match(string input, string pattern) => throw null;
                public static System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) => throw null;
                public static System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) => throw null;
                public System.TimeSpan MatchTimeout { get => throw null; }
                public System.Text.RegularExpressions.MatchCollection Matches(string input) => throw null;
                public System.Text.RegularExpressions.MatchCollection Matches(string input, int startat) => throw null;
                public static System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern) => throw null;
                public static System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) => throw null;
                public static System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) => throw null;
                public System.Text.RegularExpressions.RegexOptions Options { get => throw null; }
                protected Regex() => throw null;
                protected Regex(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) => throw null;
                public Regex(string pattern) => throw null;
                public Regex(string pattern, System.Text.RegularExpressions.RegexOptions options) => throw null;
                public Regex(string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) => throw null;
                public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator) => throw null;
                public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count) => throw null;
                public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count, int startat) => throw null;
                public string Replace(string input, string replacement) => throw null;
                public static string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator) => throw null;
                public static string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options) => throw null;
                public static string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) => throw null;
                public string Replace(string input, string replacement, int count) => throw null;
                public string Replace(string input, string replacement, int count, int startat) => throw null;
                public static string Replace(string input, string pattern, string replacement) => throw null;
                public static string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options) => throw null;
                public static string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) => throw null;
                public bool RightToLeft { get => throw null; }
                public string[] Split(string input) => throw null;
                public string[] Split(string input, int count) => throw null;
                public string[] Split(string input, int count, int startat) => throw null;
                public static string[] Split(string input, string pattern) => throw null;
                public static string[] Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) => throw null;
                public static string[] Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout) => throw null;
                public override string ToString() => throw null;
                public static string Unescape(string str) => throw null;
                protected bool UseOptionC() => throw null;
                protected internal bool UseOptionR() => throw null;
                protected internal static void ValidateMatchTimeout(System.TimeSpan matchTimeout) => throw null;
                protected internal System.Collections.Hashtable capnames;
                protected internal System.Collections.Hashtable caps;
                protected internal int capsize;
                protected internal string[] capslist;
                protected internal System.Text.RegularExpressions.RegexRunnerFactory factory;
                protected internal System.TimeSpan internalMatchTimeout;
                protected internal string pattern;
                protected internal System.Text.RegularExpressions.RegexOptions roptions;
            }

            // Generated from `System.Text.RegularExpressions.RegexCompilationInfo` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public class RegexCompilationInfo
            {
                public bool IsPublic { get => throw null; set => throw null; }
                public System.TimeSpan MatchTimeout { get => throw null; set => throw null; }
                public string Name { get => throw null; set => throw null; }
                public string Namespace { get => throw null; set => throw null; }
                public System.Text.RegularExpressions.RegexOptions Options { get => throw null; set => throw null; }
                public string Pattern { get => throw null; set => throw null; }
                public RegexCompilationInfo(string pattern, System.Text.RegularExpressions.RegexOptions options, string name, string fullnamespace, bool ispublic) => throw null;
                public RegexCompilationInfo(string pattern, System.Text.RegularExpressions.RegexOptions options, string name, string fullnamespace, bool ispublic, System.TimeSpan matchTimeout) => throw null;
            }

            // Generated from `System.Text.RegularExpressions.RegexMatchTimeoutException` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public class RegexMatchTimeoutException : System.TimeoutException, System.Runtime.Serialization.ISerializable
            {
                void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) => throw null;
                public string Input { get => throw null; }
                public System.TimeSpan MatchTimeout { get => throw null; }
                public string Pattern { get => throw null; }
                public RegexMatchTimeoutException() => throw null;
                protected RegexMatchTimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) => throw null;
                public RegexMatchTimeoutException(string message) => throw null;
                public RegexMatchTimeoutException(string message, System.Exception inner) => throw null;
                public RegexMatchTimeoutException(string regexInput, string regexPattern, System.TimeSpan matchTimeout) => throw null;
            }

            // Generated from `System.Text.RegularExpressions.RegexOptions` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            [System.Flags]
            public enum RegexOptions
            {
                Compiled,
                CultureInvariant,
                ECMAScript,
                ExplicitCapture,
                IgnoreCase,
                IgnorePatternWhitespace,
                Multiline,
                None,
                RightToLeft,
                Singleline,
            }

            // Generated from `System.Text.RegularExpressions.RegexParseError` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public enum RegexParseError
            {
                AlternationHasComment,
                AlternationHasMalformedCondition,
                AlternationHasMalformedReference,
                AlternationHasNamedCapture,
                AlternationHasTooManyConditions,
                AlternationHasUndefinedReference,
                CaptureGroupNameInvalid,
                CaptureGroupOfZero,
                ExclusionGroupNotLast,
                InsufficientClosingParentheses,
                InsufficientOpeningParentheses,
                InsufficientOrInvalidHexDigits,
                InvalidGroupingConstruct,
                InvalidUnicodePropertyEscape,
                MalformedNamedReference,
                MalformedUnicodePropertyEscape,
                MissingControlCharacter,
                NestedQuantifiersNotParenthesized,
                QuantifierAfterNothing,
                QuantifierOrCaptureGroupOutOfRange,
                ReversedCharacterRange,
                ReversedQuantifierRange,
                ShorthandClassInCharacterRange,
                UndefinedNamedReference,
                UndefinedNumberedReference,
                UnescapedEndingBackslash,
                Unknown,
                UnrecognizedControlCharacter,
                UnrecognizedEscape,
                UnrecognizedUnicodeProperty,
                UnterminatedBracket,
                UnterminatedComment,
            }

            // Generated from `System.Text.RegularExpressions.RegexParseException` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public class RegexParseException : System.ArgumentException
            {
                public System.Text.RegularExpressions.RegexParseError Error { get => throw null; }
                public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) => throw null;
                public int Offset { get => throw null; }
            }

            // Generated from `System.Text.RegularExpressions.RegexRunner` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public abstract class RegexRunner
            {
                protected void Capture(int capnum, int start, int end) => throw null;
                protected static bool CharInClass(System.Char ch, string charClass) => throw null;
                protected static bool CharInSet(System.Char ch, string set, string category) => throw null;
                protected void CheckTimeout() => throw null;
                protected void Crawl(int i) => throw null;
                protected int Crawlpos() => throw null;
                protected void DoubleCrawl() => throw null;
                protected void DoubleStack() => throw null;
                protected void DoubleTrack() => throw null;
                protected void EnsureStorage() => throw null;
                protected abstract bool FindFirstChar();
                protected abstract void Go();
                protected abstract void InitTrackCount();
                protected bool IsBoundary(int index, int startpos, int endpos) => throw null;
                protected bool IsECMABoundary(int index, int startpos, int endpos) => throw null;
                protected bool IsMatched(int cap) => throw null;
                protected int MatchIndex(int cap) => throw null;
                protected int MatchLength(int cap) => throw null;
                protected int Popcrawl() => throw null;
                protected internal RegexRunner() => throw null;
                protected internal System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick) => throw null;
                protected internal System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, System.TimeSpan timeout) => throw null;
                protected void TransferCapture(int capnum, int uncapnum, int start, int end) => throw null;
                protected void Uncapture() => throw null;
                protected internal int[] runcrawl;
                protected internal int runcrawlpos;
                protected internal System.Text.RegularExpressions.Match runmatch;
                protected internal System.Text.RegularExpressions.Regex runregex;
                protected internal int[] runstack;
                protected internal int runstackpos;
                protected internal string runtext;
                protected internal int runtextbeg;
                protected internal int runtextend;
                protected internal int runtextpos;
                protected internal int runtextstart;
                protected internal int[] runtrack;
                protected internal int runtrackcount;
                protected internal int runtrackpos;
            }

            // Generated from `System.Text.RegularExpressions.RegexRunnerFactory` in `System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a`
            public abstract class RegexRunnerFactory
            {
                protected internal abstract System.Text.RegularExpressions.RegexRunner CreateInstance();
                protected RegexRunnerFactory() => throw null;
            }

        }
    }
}
