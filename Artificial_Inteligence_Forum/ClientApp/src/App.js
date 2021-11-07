import Header from "./components/Header";
import Intro from "./components/Intro";
import Content from "./components/Content";
import RecentArticles from "./components/RecentArticles";
import Footer from "./components/Footer";
import React from 'react';

function App() {
  return (
    <div id="wrapper">
      <Header />
      <Intro />
      <Content />
      <RecentArticles />
      <Footer />
    </div>
  );
}

export default App;
