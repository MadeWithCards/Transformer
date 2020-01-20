import * as ACData from "adaptivecards-templating";

export class Transformer {
    constructor() {
    }

    transform(inputJson: string, templateToUse: string): any {
        let template = new ACData.Template(templateToUse);
        var context = new ACData.EvaluationContext();
        context.$root = inputJson;
        var data = template.expand(context);
        return data;
    }
}