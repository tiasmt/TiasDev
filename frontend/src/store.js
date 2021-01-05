import axios from 'axios';
import Vue from 'vue';
import Vuex from 'vuex';
import { apiHost } from "@/main.js";
// import router from './router'

Vue.use(Vuex)

export default new Vuex.Store({
    state: {
        filter: "",
        allPosts: [],
        filteredPosts: [],
        currentPost: null
    },
    mutations: {
        addFilter(state, filter) {
            state.filter = filter.filter;
            if (filter.filter == "all") {
                state.filteredPosts = state.allPosts.posts;
            } else {
                var filteredPosts = state.allPosts.posts.filter(function (el) {
                    return el.category == filter.filter
                });
                state.filteredPosts = filteredPosts;
            }
        },
        getPosts(state, posts) {
            state.allPosts = posts;
            state.filteredPosts = posts.posts;
        },
        searchPosts(state, search) {
            if (state.allPosts.posts) {
                var filteredPosts = state.allPosts.posts.filter(function (el) {
                    return ((el.category.toLowerCase().includes(search.search) ||
                        el.title.toLowerCase().includes(search.search) ||
                        el.summary.toLowerCase().includes(search.search)) && (el.category == state.filter || state.filter == "all" || state.filter == ""));

                });
            }
            state.filteredPosts = filteredPosts;
        },
        getPost(state, data){
            state.currentPost = data.post;
        }
    },
    
    actions: {
        AddFilter({ commit }, data) {
            commit('addFilter', data);
        },
        GetPosts({ commit }) {
            axios.get(apiHost + "/posts/getall").
                then((response) => {
                    if (response.status == 200) {
                        commit('getPosts', { posts: response.data });
                    }
                }).catch((e) => {
                    commit('setError', {
                        error: e.response.data.error
                    });
                });
        },
        SearchPosts({ commit }, search) {
            commit('searchPosts', search);
        },
        GetPost({ commit }, data) {
            var postId = data.id;
            axios.get(apiHost + "/posts/" + postId).
                then((response) => {
                    if (response.status == 200) {
                        commit('getPost', { post: response.data });
                    }
                }).catch((e) => {
                    commit('setError', {
                        error: e.response.data.error
                    });
                });
        },

    },
    getters: {
    }

});