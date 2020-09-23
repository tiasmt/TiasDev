<template lang="html">
  <nav class="navbar">
    <div class="icons">
      <a href="https://github.com/tiasmt"
        ><img src="../assets/icons/github.svg" alt="Kiwi standing on oval"
      /></a>
      <a href="https://twitter.com/tiiaasss"
        ><img src="../assets/icons/twitter.svg" alt="Kiwi standing on oval"
      /></a>
    </div>
    <ul>
      <li>
        <router-link class="home" to="/">Home</router-link>
      </li>
      <li>
        <router-link class="portfolio" to="/portfolio">Portfolio</router-link>
      </li>
      <li>
        <router-link class="technology" to="/technology"
          >Technology</router-link
        >
      </li>
      <li>
        <router-link class="knowledge" to="/knowledge">Knowledge</router-link>
      </li>
      <li>
        <router-link class="algorithms" to="/algorithms"
          >Algorithms</router-link
        >
      </li>
      <li>
        <router-link class="books" to="/books">Books</router-link>
      </li>
    </ul>
  </nav>
</template>

<script>
export default {};
</script>

<style lang="scss" scoped>
.navbar {
  position: fixed;
  height: 100vh;
  width: 20%;
  border-right: 1px solid rgba(104, 104, 104, 0.1);
  font-size: 20px;
}
ul {
  list-style-type: none;
  position: relative;
  top: 30%;
  left: 10%;
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
  transition: 0.1s;
}

li a::before {
  height: 0px;
  -webkit-transition: all 250ms;
  transition: all 250ms;
  margin-top: 4px;
  margin-right: 4%;
  float: left;
  content: " ";
}

.home::before {
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

li a:hover::before {
  width: 2px;
  height: 18px;
  content: " ";
}

li {
  margin-top: 10%;
}

img {
  width: 12%;
  margin-left: 22%;
}

.icons {
  background-color: rgba(104, 104, 104, 0.1);
  height: 4%;
}</style
>>
