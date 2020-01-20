"use strict";
exports.__esModule = true;
var ACData = require("adaptivecards-templating");
var Transformer = /** @class */ (function () {
    function Transformer() {
    }
    Transformer.prototype.transform = function (inputJson, templateToUse) {
        var template = new ACData.Template(templateToUse);
        var context = new ACData.EvaluationContext();
        context.$root = inputJson;
        var data = template.expand(context);
        return data;
    };
    return Transformer;
}());
exports.Transformer = Transformer;
