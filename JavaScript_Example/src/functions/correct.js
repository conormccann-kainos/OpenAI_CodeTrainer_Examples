
function isPalindrome(str) {
  const len = str.length;
  for (let i = 0; i < Math.floor(len / 2); i++) {
    if (str[i] !== str[len - i - 1]) {
      return false;
    }
  }
  return true;
}

module.exports = isPalindrome;
