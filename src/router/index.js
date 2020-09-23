import Vue from "vue";
import VueRouter from "vue-router";
import Home from "../views/Home.vue";
import Portfolio from "../views/Portfolio.vue";
import Technology from "../views/Technology.vue";
import Books from "../views/Books.vue";
import Knowledge from "../views/Knowledge.vue";
import Algorithms from "../views/Algorithms.vue";

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home
  },
  {
    path: "/Portfolio",
    name: "Portfolio",
    component: Portfolio
  },
  {
    path: "/Technology",
    name: "Technology",
    component: Technology
  },
  {
    path: "/Books",
    name: "Books",
    component: Books
  },
  {
    path: "/Knowledge",
    name: "Knowledge",
    component: Knowledge
  },
  {
    path: "/Algorithms",
    name: "Algorithms",
    component: Algorithms
  }
  // {
  //   path: "/about",
  //   name: "About",
  //   // route level code-splitting
  //   // this generates a separate chunk (about.[hash].js) for this route
  //   // which is lazy-loaded when the route is visited.
  //   component: () =>
  //     import(/* webpackChunkName: "about" */ "../views/About.vue")
  // }
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes
});

export default router;
