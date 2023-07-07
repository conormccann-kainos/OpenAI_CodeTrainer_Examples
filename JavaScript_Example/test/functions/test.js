
const assert = require('assert');
const isPalindrome = require('../../src/functions/incorrect');

describe('isPalindrome function', () => {
  it('should return true for "racecar"', () => {
    assert.equal(isPalindrome('racecar'), true);
  });
  
  it('should return true for "level"', () => {
    assert.equal(isPalindrome('level'), true);
  });
  
  it('should return false for "hello"', () => {
    assert.equal(isPalindrome('hello'), false);
  });
  
  it('should return true for "A man a plan a canal Panama"', () => {
    assert.equal(isPalindrome('A man a plan a canal Panama'), true);
  });
});
