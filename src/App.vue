<template>
  <div id="app">
    <router-view></router-view>
  </div>
</template>

<style lang="scss">
#app {
  margin: 0px;
  padding: 0px;
  box-sizing: border-box;
}

body {
  margin: 0px;
  padding: 0px;
}

html {
  // font-family: 'Montserrat';
  font-family: "Open Sans", Helvetica, arial, sans-serif;
  font-weight: 500;
  font-size: 30px;
  text-rendering: optimizeLegibility;
  scroll-behavior: smooth;
  color: #2c3e50;
  background-color: #f4f6f8;
}

.content {
  margin-left: 20%;
  width: 80%;
}

.home span {
  &::before {
    background-color: #51c557c9;
  }
}
.portfolio span {
  &::before {
    background-color: rgb(75, 158, 236);
  }
}
.technology span {
  &::before {
    background-color: rgb(207, 58, 58);
  }
}
.knowledge span {
  &::before {
    background-color: rgb(78, 163, 106);
  }
}
.algorithms span {
  &::before {
    background-color: rgba(228, 166, 52, 0.938);
  }
}
.books span {
  &::before {
    background-color: rgba(47, 47, 46, 0.52);
  }
}

/* Smartphones (portrait and landscape) ----------- */
@media only screen and (min-width: 320px) and (max-width: 480px) {
  /* Styles */
}

/* Smartphones (landscape) ----------- */
@media only screen and (min-width: 321px) {
  /* Styles */
}

/* Smartphones (portrait) ----------- */
@media only screen and (max-width: 320px) {
  /* Styles */
}

/* iPads (portrait and landscape) ----------- */
@media only screen and (min-width: 768px) and (max-width: 1024px) {
  /* Styles */
}

/* iPads (landscape) ----------- */
@media only screen and (min-width: 768px) and (max-width: 1024px) and (orientation: landscape) {
  /* Styles */
}

/* iPads (portrait) ----------- */
@media only screen and (min-width: 768px) and (max-width: 1024px) and (orientation: portrait) {
  /* Styles */
}

/* Desktops and laptops ----------- */
@media only screen and (min-width: 1224px) {
  /* Styles */
}

/* Large screens ----------- */
@media only screen and (min-width: 1824px) {
  /* Styles */
}

/* iPhone 4 ----------- */
@media only screen and (-webkit-min-device-pixel-ratio: 1.5),
  only screen and (min-device-pixel-ratio: 1.5) {
  /* Styles */
}
</style>
