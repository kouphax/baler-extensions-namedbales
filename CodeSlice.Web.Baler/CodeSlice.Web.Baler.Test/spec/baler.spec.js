describe("Bale Single File", function(){
    it("should successfuly bale a single file using a named bale into javascript without changing the behaviour", function(){
        expect(window.globalSimple).toBeDefined();
        expect(window.globalSimple).toBe('success');
    });
});