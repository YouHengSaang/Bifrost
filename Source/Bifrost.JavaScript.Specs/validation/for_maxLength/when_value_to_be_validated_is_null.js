﻿describe("when value to be validated is null", function () {
    it("should be false", function () {
        var value = Bifrost.validation.ruleHandlers.maxLength.validate(null, { length: 3 });
        expect(value).toBeFalsy();
    });
});
