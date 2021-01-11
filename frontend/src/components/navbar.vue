<template lang="html">
  <nav class="navbar">
   
    <div class="overview">
      <!-- <h1>Tias Finks</h1> -->
      Curation of thoughts. <br><br>
      Feel free to visit my portfolio here. <br><br>
      Click on any of the below to filter the blog posts according to the criteria.

    </div>
    <ul>
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
    return {};
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
  /* Styles */
}

/* Smartphones (landscape) ----------- */
@media only screen and (min-width: 321px) {
  * {
    font-size: 16px;
  }

  .icons {
    display: none;
  }

  img {
    margin-left: 27%;
  }

  .overview {
    margin-top: 5%;
    margin-bottom: 0%;
  }

  .navbar {
    position: fixed;
    width: 100%;
    border-right: 1px solid rgba(104, 104, 104, 0.1);
    font-size: 65%;
  }

  ul {
    margin-top: 0%;
    top: 5%;
    left: -4%;
    height: 8%;
    border-bottom: 1px solid rgba(12, 12, 12, 0.05);
    width: 100%;
  }

  li {
    margin-top: 2%;
    float: left;
    margin-left: 10px;
    
  }
  .filter-on::before {
    width: 0px;
    height: 0px;
  }
  .filter-on::after {
    width: 20px;
    height: 2px;
    content: " ";
    display: block;
    margin-top: 3px;
    margin-left: 25%;
  }

  a, a:active {
    margin-left: 0px;
    color: rgba(16, 15, 15, 0.481);
  }

    .filter-on {
    color: black;
    font-size: 105%;
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
    width: 30px;
  }
  .books::after {
    background-color: rgb(47, 47, 46);
  }

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
  * {
    font-size: 20px;
  }

  .icons {
    height: 4%;
  }

  img {
    margin-left: 27%;
  }

  .overview {
    margin-top: 25%;
    font-size: 90%;
  }
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
