<template lang="html">
  <nav class="navbar">
   
    <div class="overview">
      <!-- <h1>Tias Finks</h1> -->
      Curation of thoughts. <br><br>
      Feel free to visit my portfolio here. <br><br>
      Click on any of the below to filter the blog posts according to the criteria.

    </div>
    <ul id="filters" class="sticky-navbar">
      <li>
        <a @click="SetActive" class="all filter-on">All</a>
      </li>
      <li>
        <a @click="SetActive" class="technology">Technology</a>
      </li>
      <li>
        <a @click="SetActive" class="knowledge">Knowledge</a>
      </li>
      <li>
        <a @click="SetActive" class="algorithms">Algorithms</a>
      </li>
      <li>
        <a @click="SetActive" class="books">Books</a>
      </li>
    </ul>
     <div class="icons">
      <a href="https://github.com/tiasmt"
        ><img src="../assets/icons/github.svg" alt="Kiwi standing on oval"
      /></a>
      <a href="https://twitter.com/tiiaasss"
        ><img src="../assets/icons/twitter.svg" alt="Kiwi standing on oval"
      /></a>
    </div>
  </nav>
</template>

<script>
export default {
  data() {
    return {
      filters: null,
      sticky: null,
    };
  },
  methods: {
    SetActive(event) {
      var list = document.getElementsByTagName("LI");
      var filter = event.target.innerText.toLowerCase();
      list.forEach((element) => {
        if (element.firstChild.classList.contains("filter-on"))
          element.firstChild.classList.remove("filter-on");
      });
      var element = event.target;
      element.classList.add("filter-on");
      this.$store.dispatch("AddFilter", {
        filter: filter,
      });
    },
    HandleScroll() {
      if (window.pageYOffset >= this.sticky) {
        this.filters.classList.add("sticky");
      } else {
        this.filters.classList.remove("sticky");
      }
    },
  },
  mounted() {
    window.addEventListener("scroll", this.HandleScroll);
    this.filters = document.getElementById("filters");
    this.sticky = this.filters.offsetTop;
  },
  destroyed() {
    window.removeEventListener("scroll", this.HandleScroll);
  },
};
</script>

<style lang="scss" scoped>
.navbar {
  position: fixed;
  height: 100vh;
  width: 35%;
  border-right: 1px solid rgba(104, 104, 104, 0.1);
  font-size: 65%;
}
ul {
  list-style-type: none;
  position: relative;
  top: 10%;
  left: 20%;
}

a:link {
  text-decoration: none;
  color: rgb(20, 19, 19);
}

a:visited {
  text-decoration: none;
  color: rgb(20, 19, 19);
}

a {
  text-decoration: none;
  transition: 0.5s;
  cursor: pointer;
  color: rgb(20, 19, 19);
}

li a::before {
  height: 0px;
  -webkit-transition: all 300ms;
  transition: all 300ms;
  margin-top: 3px;
  margin-right: 4%;
  float: left;
  content: " ";
}

li a:hover::before {
  width: 2px;
  height: 18px;
  content: " ";
  margin-left: 3px;
}

a:active {
  margin-left: 3px;
}

li {
  margin-top: 5%;
}

img {
  width: 12%;
  margin-left: 22%;
  margin-top: 1%;
}

.icons {
  background-color: rgba(104, 104, 104, 0.1);
  height: 6%;
  bottom: 0%;
  position: absolute;
  width: 100%;
}

.overview {
  margin-top: 15%;
  text-align: center;
  width: 90%;
  margin-left: 5%;
}

.filter-on::before {
  width: 2px;
  height: 18px;
  content: " ";
  margin-left: 3px;
}

.all::before {
  background-color: rgb(236, 75, 75);
}
.portfolio::before {
  background-color: rgb(75, 158, 236);
}
.technology::before {
  background-color: rgb(136, 40, 40);
}
.knowledge::before {
  background-color: rgb(78, 163, 106);
}
.algorithms::before {
  background-color: rgb(207, 140, 52);
}
.books::before {
  background-color: rgb(47, 47, 46);
}

/* Smartphones (portrait and landscape) ----------- */
@media only screen and (min-width: 320px) and (max-width: 480px) {
  * {
    font-size: 16px;
  }

  .navbar {
    width: 99%;
    position: relative;
    height: 100%;
    border-right: 0px solid rgba(104, 104, 104, 0.1);
  }

  .filter-on::before {
    width: 0px;
    height: 0px;
    margin-left: 0px;
  }

  .filter-on::after {
    width: 18px;
    height: 2px;
    margin-left: 0px;
    content: " ";
    display: block;
    margin-top: 3%;
    margin-left: 35%;
  }

  .filter-on {
    font-size: 100%;
    color: black;
  }

  ul {
    left: 0;
    top: 0;
    padding-left: 18%;
    padding-bottom: 8%;
    border-bottom: 1px solid rgba(211, 210, 210, 0.296);
    overflow: hidden;
  }

  li {
    float: left;
    margin-right: 3%;
  }

  a {
    font-size: 75%;
    color: rgba(0, 0, 0, 0.481);
  }

  li a::before {
    height: 0px;
    margin-top: 0px;
    margin-right: 0px;
    float: left;
    content: " ";
  }

  li a:hover::before {
    width: 0px;
    height: 0px;
    content: " ";
    margin-left: 0px;
  }

  .all::after {
    background-color: rgb(236, 75, 75);
    width: 8px;
  }
  .portfolio::after {
    background-color: rgb(75, 158, 236);
  }
  .technology::after {
    background-color: rgb(136, 40, 40);
  }
  .knowledge::after {
    background-color: rgb(78, 163, 106);
  }
  .algorithms::after {
    background-color: rgb(207, 140, 52);
  }
  .books::after {
    background-color: rgb(47, 47, 46);
  }

  .icons {
    display: none;
  }

  img {
    margin-left: 25%;
    height: 90%;
  }

  .sticky-navbar {
    transition: all 1s;
    background: transparent;
    background: rgb(255, 255, 255);
  }
  /* The sticky class is added to the navbar with JS when it reaches its scroll position */
  .sticky {
    margin-top: 0px;
    opacity: 1;
    position: fixed;
    width: 100%;
    background: rgba(255, 255, 255, 0.938);
    z-index: 999;
  }
}

/* Smartphones (portrait) ----------- */
@media only screen and (max-width: 320px) {
  * {
    font-size: 14px;
  }

  .navbar {
    width: 99%;
    border-right: 0px solid rgba(104, 104, 104, 0.1);
  }

  .filter-on::before {
    width: 0px;
    height: 0px;
    margin-left: 0px;
  }

  .filter-on::after {
    width: 18px;
    height: 2px;
    margin-left: 0px;
    content: " ";
    display: block;
    margin-top: 3%;
    margin-left: 35%;
  }

  .filter-on {
    font-size: 100%;
    color: black;
  }

  ul {
    left: 0;
    top: 0;
    padding-left: 10%;
    height: 10%;
    border-bottom: 1px solid rgba(211, 210, 210, 0.296);
  }

  li {
    float: left;
    margin-right: 3%;
  }

  a {
    font-size: 70%;
    color: rgba(0, 0, 0, 0.481);
  }

  li a::before {
    height: 0px;
    margin-top: 0px;
    margin-right: 0px;
    float: left;
    content: " ";
  }

  li a:hover::before {
    width: 0px;
    height: 0px;
    content: " ";
    margin-left: 0px;
  }

  .all::after {
    background-color: rgb(236, 75, 75);
    width: 8px;
  }
  .portfolio::after {
    background-color: rgb(75, 158, 236);
  }
  .technology::after {
    background-color: rgb(136, 40, 40);
  }
  .knowledge::after {
    background-color: rgb(78, 163, 106);
  }
  .algorithms::after {
    background-color: rgb(207, 140, 52);
  }
  .books::after {
    background-color: rgb(47, 47, 46);
  }

  .sticky-navbar {
    transition: all 300ms;
    background: transparent;
    opacity: 0;
  }
  /* The sticky class is added to the navbar with JS when it reaches its scroll position */
  .sticky {
    opacity: 1;
    position: fixed;
    top: 0;
    width: 100%;
    background: rgb(33, 30, 30);
  }
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
}

/* Desktops and laptops ----------- */
@media only screen and (min-width: 1224px) {
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
