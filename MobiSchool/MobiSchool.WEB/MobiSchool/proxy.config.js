const proxy = [
    {
      context: '/api',
      target: 'http://localhost:44383',
      secure: 'false',
      changeOrigin: true,
    }
  ];
  module.exports = proxy;