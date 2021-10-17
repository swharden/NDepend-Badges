# NDepend Badges

[![CI](https://github.com/swharden/NDepend-Badges/actions/workflows/ci.yaml/badge.svg)](https://github.com/swharden/NDepend-Badges/actions/workflows/ci.yaml)

**This project creates status badges that display code metrics from [NDepend](https://www.ndepend.com/) reports.** Badges are similar in style to those created by [badgen.net](https://badgen.net/) and [shields.io](https://shields.io/).

```cs
var report = new Report("NDependTrendData.xml");
report.MakeBadges(report.LatestMetrics, "badges/");
```

### SVG

![](reports/badges/new-issues-since-baseline.svg)
![](reports/badges/issues-fixed-since-baseline.svg)
![](reports/badges/issues-worsened-since-baseline.svg)
![](reports/badges/issues-with-severity-blocker.svg)
![](reports/badges/issues-with-severity-critical.svg)
![](reports/badges/issues-with-severity-high.svg)
![](reports/badges/issues-with-severity-medium.svg)
![](reports/badges/issues-with-severity-low.svg)
![](reports/badges/blocker-critical-high-issues.svg)
![](reports/badges/issues.svg)
![](reports/badges/suppressed-issues.svg)
![](reports/badges/rules.svg)
![](reports/badges/rules-violated.svg)
![](reports/badges/critical-rules-violated.svg)
![](reports/badges/quality-gates.svg)
![](reports/badges/quality-gates-warn.svg)
![](reports/badges/quality-gates-fail.svg)
![](reports/badges/percentage-debt-metric.svg)
![](reports/badges/debt-metric.svg)
![](reports/badges/annual-interest-metric.svg)
![](reports/badges/breaking-point.svg)
![](reports/badges/breaking-point-of-blocker-critical-high-issues.svg)
![](reports/badges/lines-of-code.svg)
![](reports/badges/lines-of-code-justmycode.svg)
![](reports/badges/lines-of-code-notmycode.svg)
![](reports/badges/source-files.svg)
![](reports/badges/il-instructions.svg)
![](reports/badges/il-instructions-notmycode.svg)
![](reports/badges/assemblies.svg)
![](reports/badges/namespaces.svg)
![](reports/badges/types.svg)
![](reports/badges/public-types.svg)
![](reports/badges/classes.svg)
![](reports/badges/abstract-classes.svg)
![](reports/badges/interfaces.svg)
![](reports/badges/structures.svg)
![](reports/badges/methods.svg)
![](reports/badges/abstract-methods.svg)
![](reports/badges/concrete-methods.svg)
![](reports/badges/fields.svg)
![](reports/badges/max-lines-of-code-for-methods-justmycode.svg)
![](reports/badges/average-lines-of-code-for-methods.svg)
![](reports/badges/average-lines-of-code-for-methods-with-at-least-3-lines-of-code.svg)
![](reports/badges/max-lines-of-code-for-types-justmycode.svg)
![](reports/badges/average-lines-of-code-for-types.svg)
![](reports/badges/max-cyclomatic-complexity-for-methods.svg)
![](reports/badges/average-cyclomatic-complexity-for-methods.svg)
![](reports/badges/max-il-cyclomatic-complexity-for-methods.svg)
![](reports/badges/average-il-cyclomatic-complexity-for-methods.svg)
![](reports/badges/max-il-nesting-depth-for-methods.svg)
![](reports/badges/average-il-nesting-depth-for-methods.svg)
![](reports/badges/max-of-methods-for-types.svg)
![](reports/badges/average-methods-for-types.svg)
![](reports/badges/max-of-methods-for-interfaces.svg)
![](reports/badges/average-methods-for-interfaces.svg)
![](reports/badges/lines-of-code-uncoverable.svg)
![](reports/badges/third-party-assemblies-used.svg)
![](reports/badges/third-party-namespaces-used.svg)
![](reports/badges/third-party-types-used.svg)
![](reports/badges/third-party-methods-used.svg)
![](reports/badges/third-party-fields-used.svg)
![](reports/badges/rules-violations.svg)
![](reports/badges/critical-rules.svg)
![](reports/badges/critical-rules-violations.svg)

### PNG

![](reports/badges/new-issues-since-baseline.png)
![](reports/badges/issues-fixed-since-baseline.png)
![](reports/badges/issues-worsened-since-baseline.png)
![](reports/badges/issues-with-severity-blocker.png)
![](reports/badges/issues-with-severity-critical.png)
![](reports/badges/issues-with-severity-high.png)
![](reports/badges/issues-with-severity-medium.png)
![](reports/badges/issues-with-severity-low.png)
![](reports/badges/blocker-critical-high-issues.png)
![](reports/badges/issues.png)
![](reports/badges/suppressed-issues.png)
![](reports/badges/rules.png)
![](reports/badges/rules-violated.png)
![](reports/badges/critical-rules-violated.png)
![](reports/badges/quality-gates.png)
![](reports/badges/quality-gates-warn.png)
![](reports/badges/quality-gates-fail.png)
![](reports/badges/percentage-debt-metric.png)
![](reports/badges/debt-metric.png)
![](reports/badges/annual-interest-metric.png)
![](reports/badges/breaking-point.png)
![](reports/badges/breaking-point-of-blocker-critical-high-issues.png)
![](reports/badges/lines-of-code.png)
![](reports/badges/lines-of-code-justmycode.png)
![](reports/badges/lines-of-code-notmycode.png)
![](reports/badges/source-files.png)
![](reports/badges/il-instructions.png)
![](reports/badges/il-instructions-notmycode.png)
![](reports/badges/assemblies.png)
![](reports/badges/namespaces.png)
![](reports/badges/types.png)
![](reports/badges/public-types.png)
![](reports/badges/classes.png)
![](reports/badges/abstract-classes.png)
![](reports/badges/interfaces.png)
![](reports/badges/structures.png)
![](reports/badges/methods.png)
![](reports/badges/abstract-methods.png)
![](reports/badges/concrete-methods.png)
![](reports/badges/fields.png)
![](reports/badges/max-lines-of-code-for-methods-justmycode.png)
![](reports/badges/average-lines-of-code-for-methods.png)
![](reports/badges/average-lines-of-code-for-methods-with-at-least-3-lines-of-code.png)
![](reports/badges/max-lines-of-code-for-types-justmycode.png)
![](reports/badges/average-lines-of-code-for-types.png)
![](reports/badges/max-cyclomatic-complexity-for-methods.png)
![](reports/badges/average-cyclomatic-complexity-for-methods.png)
![](reports/badges/max-il-cyclomatic-complexity-for-methods.png)
![](reports/badges/average-il-cyclomatic-complexity-for-methods.png)
![](reports/badges/max-il-nesting-depth-for-methods.png)
![](reports/badges/average-il-nesting-depth-for-methods.png)
![](reports/badges/max-of-methods-for-types.png)
![](reports/badges/average-methods-for-types.png)
![](reports/badges/max-of-methods-for-interfaces.png)
![](reports/badges/average-methods-for-interfaces.png)
![](reports/badges/lines-of-code-uncoverable.png)
![](reports/badges/third-party-assemblies-used.png)
![](reports/badges/third-party-namespaces-used.png)
![](reports/badges/third-party-types-used.png)
![](reports/badges/third-party-methods-used.png)
![](reports/badges/third-party-fields-used.png)
![](reports/badges/rules-violations.png)
![](reports/badges/critical-rules.png)
![](reports/badges/critical-rules-violations.png)
