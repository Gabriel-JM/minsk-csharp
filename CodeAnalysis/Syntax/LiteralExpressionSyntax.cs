using System.Collections.Generic;

namespace Minsk.CodeAnalysis.Syntax {
    public sealed class LiteralExpressionSyntax : ExpressionSyntax {
        public override SyntaxKind Kind => SyntaxKind.LiteralExpression;
        public SyntaxToken LiteralToken { get; }

        public LiteralExpressionSyntax(SyntaxToken literalToken) {
            LiteralToken = literalToken;
        }

        public override IEnumerable<SyntaxNode> GetChildren() {
            yield return LiteralToken;
        }
    }
}